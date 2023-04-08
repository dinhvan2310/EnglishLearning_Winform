using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using BLL.EntityFrameWork;
using BLL.EntityFrameWork.Model;
using BLL.TransferObjects;
using MySqlX.XDevAPI.Common;
using Mysqlx.Crud;
using PBLLibrary;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using BLL.Migrations;

namespace BLL.Components
{
    public class EDictionaryMananger
    {
        private readonly string[] _VerbFrames = new string[]
        {
            "",
            "Something ----s",
            "Somebody ----s",
            "It is ----ing",
            "Something is ----ing PP",
            "Something ----s something Adjective/Noun",
            "Somebody ----s Adjective/Noun",
            "Somebody ----s Adjective",
            "Somebody ----s something",
            "Somebody ----s somebody",
            "Something ----s somebody",
            "Something ----s something",
            "Something ----s to somebody",
            "Somebody ----s on something",
            "Somebody ----s somebody something",
            "Somebody ----s something to somebody",
            "Somebody ----s something from somebody",
            "Somebody ----s somebody with something",
            "Somebody ----s somebody of something",
            "Something ----s something on somebody",
            "Somebody ----s somebody PP",
            "Somebody ----s something PP",
            "Somebody ----s PP",
            "Somebody's (body part) ----s",
            "Somebody ----s somebody to INFINITIVE",
            "Somebody ----s somebody INFINITIVE",
            "Somebody ----s that CLAUSE",
            "Somebody ----s to somebody",
            "Somebody ----s to INFINITIVE",
            "Somebody ----s whether INFINITIVE",
            "Somebody ----s somebody into V-ing something",
            "Somebody ----s something with something",
            "Somebody ----s INFINITIVE",
            "Somebody ----s VERB-ing",
            "It ----s that CLAUSE",
            "Something ----s INFINITIVE"
        };
        public List<WordModel> GetWord_Random(int limit = 10)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();
                Random r = new Random();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Join(
                                    dbContext.wn_word
                                        .Shuffle(r)
                                        .Select(x => x.synset_id)
                                        .Take(limit * 4),
                                    w => w.synset_id,
                                    s => s,
                                    (w, s) => new { Word = w, SynsetId = s })
                                .Select(w => new { w.Word.word, w.Word.w_num })
                                .ToList();

                temp.ForEach(item =>
                {
                    if (wn_words.Count < limit && (double)item.w_num == Math.Ceiling(r.NextDouble() * 6))
                    {
                        wn_words.Add(item.word.ToString());
                    }
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        public List<WordModel> GetWord_ByFilter_Random(string filter, int limit = 10, bool distinct = false)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();


                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                if (distinct)
                {
                    List<string> words = dbContext.wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .Select(w => w.word.ToString())
                                         .Distinct()
                                         .Shuffle(new Random())
                                         .Take(limit).ToList();
                    words.ForEach(item =>
                    {
                        results.Add(new WordModel(item.ToString()));
                    });
                }
                else
                {
                    List<wn_word> wn_words = dbContext.wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .OrderBy(w => Guid.NewGuid())
                                         .Take(limit).ToList();
                    wn_words.ForEach(item =>
                    {
                        results.Add(new WordModel(item.word));
                    });
                }
                return results;
            }
        }

        public List<WordModel> GetWord_BySynsetID(decimal id)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Where(p => p.synset_id.Equals(id))
                                .Select(p => p.word)
                                .ToList();

                temp.ForEach(item =>
                {
                    wn_words.Add(item.ToString());
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        /// <summary>
        /// Including similar words and synset words family
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<WordModel> GetSynonymWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<SynsetModel> ss = GetSynset_ByWord(word);
                List<string> wn_words = new List<string>();

                foreach (SynsetModel s in ss)
                {
                    var temp = dbContext.wn_word
                                    .Where(p => p.synset_id.Equals(s.ID))
                                    .Select(p => p.word)
                                    .ToList();

                    temp.ForEach(item =>
                    {
                        wn_words.Add(item.ToString());
                    });
                }

                wn_words = wn_words.Distinct().ToList();
                // except base word
                wn_words.Remove(word);
                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        public List<SynsetModel> GetSynset_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<SynsetModel> results = null;
                var synsets = dbContext.wn_word.Where(i => i.word == word)
                    .Include(p => p.wn_synset).ToList();
                results = synsets.Select(i => new SynsetModel()
                {
                    ID = i.synset_id,
                    Definition = i.wn_synset.definition,
                    Words = new List<WordModel>
                    {
                        new WordModel(i.word)
                    }
                }).ToList();
                return results;
            }
        }
        
        public List<WordModel> GetWord_ByFilter(string filter, int limit = 10, bool distinct = false)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                if (distinct)
                {
                    List<string> words = dbContext.wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .Select(w => w.word.ToString())
                                         .Distinct()
                                         .Take(limit).ToList();

                    words.ForEach(item =>
                    {
                        results.Add(new WordModel(item.ToString()));
                    });
                }
                else
                {
                    List<wn_word> wn_words = dbContext.wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .Take(limit)
                                         .ToList();

                    wn_words.ForEach(item =>
                    {
                        results.Add(new WordModel(item.word));
                    });
                }

                return results;

            }
        }

        public List<WordModel> GetSimilarWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.wn_similar,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => new { w.word })
                                .Select(p => p.word)
                                .ToList();

                temp.ForEach(item =>
                {
                    wn_words.Add(item.ToString());
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        public List<WordModel> GetAntonymWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.wn_antonym,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => new { w.word })
                                .Select(p => p.word)
                                .ToList();

                temp.ForEach(item =>
                {
                    wn_words.Add(item.ToString());
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        public List<string> GetVerbFrame_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<string> results = new List<string>();

                var temp = dbContext.wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.wn_verb_frame,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { W1 = a.w_num, W2 = w.w_num, F = a.f_num })
                                .Where(p => p.W1 == p.W2)
                                .Select(p => p.F)
                                .ToList();

                temp.ForEach(item =>
                {
                    results.Add(_VerbFrames[Convert.ToInt32(item.ToString())]);
                });
                return results;
            }
        }

        public List<WordModel> GetDerivedWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.wn_derived,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => new { w.word })
                                .Where(p => p.word.Contains(word))
                                .Select(p => p.word)
                                .Distinct()
                                .ToList();

                temp.ForEach(item =>
                {
                    wn_words.Add(item.ToString());
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }

        public List<WordModel> GetHypernymWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();

                List<string> wn_words = new List<string>();
                var temp = dbContext.wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.wn_derived,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => new { w.word })
                                .Where(p => p.word.Contains(word))
                                .Select(p => p.word)
                                .Distinct()
                                .ToList();

                temp.ForEach(item =>
                {
                    wn_words.Add(item.ToString());
                });

                wn_words.ForEach(item =>
                {
                    results.Add(new WordModel(item.ToString()));
                });
                return results;
            }
        }
    }
}
