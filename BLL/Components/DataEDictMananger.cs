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

namespace BLL.Components
{
    public class DataEDictMananger
    {
        
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
    }
}
