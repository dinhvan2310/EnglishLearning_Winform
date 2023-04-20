using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using BLL.TransferObjects;
using MySqlX.XDevAPI.Common;
using Mysqlx.Crud;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using BLL.Migrations;
using EFramework;
using EFramework.Model;
using System.Collections;
using PBLLibrary;
using BLL.EnityFramework.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using Library;
using EFramework.Migrations;

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
        public List<wn_word> GetWord_Random(int limit = 10)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();
                Random r = new Random();

                List<string> Wn_words = new List<string>();

                var temp = dbContext.Wn_word
                                .Shuffle(r)
                                .Select(x => x.synset_id)
                                .Take(limit * 4)
                                .Join(
                                    dbContext.Wn_word,
                                    s => s,
                                    w => w.synset_id,
                                    (s, w) => new { Word = w, SynsetId = s })
                                .Select(w => new { w.Word.word, w.Word.w_num })
                                .ToList();

                temp.ForEach(item =>
                {
                    if (Wn_words.Count < limit && (double)item.w_num == Math.Ceiling(r.NextDouble() * 6))
                    {
                        results.Add(new wn_word() { word = item.word });
                    }
                });

                return results;
            }
        }

        public List<wn_word> GetWord_ByFilter_Random(string filter, int limit = 10, bool distinct = false)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();


                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                if (distinct)
                {
                    results = dbContext.Wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .Shuffle(new Random())
                                         .ToList();

                    results = results.GroupBy(p => p.word)
                        .Select(p => p.First())
                        .Take(limit).ToList();
                }
                else
                {
                    results = dbContext.Wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .OrderBy(w => Guid.NewGuid())
                                         .Take(limit)
                                         .ToList();
                }
                return results;
            }
        }

        public List<wn_word> GetWord_BySynsetID(decimal id)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();

                List<string> Wn_words = new List<string>();
                results = dbContext.Wn_word
                                .Where(p => p.synset_id.Equals(id))
                                .ToList();

                return results;
            }
        }

        /// <summary>
        /// Including similar words and synset words family
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<wn_word> GetSynonymWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();
                List<wn_synset> ss = GetSynset_ByWord(word); // word family synsets

                foreach (wn_synset s in ss)
                {
                    var temp = dbContext.Wn_word
                                    .Where(p => p.synset_id.Equals(s.synset_id) && p.word != word)
                                    .ToList();

                    results.AddRange(temp);
                }

                results.AddRange(GetSimilarWord_ByWord(word));

                results = results.GroupBy(p => p.word)
                        .Select(p => p.First())
                        .ToList();


                return results;
            }
        }

        public List<wn_synset> GetSynset_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_synset> results = null;
                results = dbContext.Wn_word
                    .Where(p => p.word == word)
                    .Select(p => p.Wn_synset)
                    .ToList();
                
                return results;
            }
        }
        
        public List<wn_word> GetWord_ByFilter(string filter, int limit = 10, bool distinct = false)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();

                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                if (distinct)
                {
                    results = dbContext.Wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .ToList();

                    results = results.GroupBy(p => p.word)
                                .Select(p => p.First())
                                .Take(limit).ToList();
                }
                else
                {
                    results = dbContext.Wn_word
                                         .Where(w =>
                                             startWith && endWith ? w.word.Contains(filter) :
                                             startWith ? w.word.StartsWith(filter) :
                                             endWith ? w.word.EndsWith(filter) :
                                             w.word.Equals(filter))
                                         .Take(limit)
                                         .ToList();
                }

                return results;

            }
        }

        public List<wn_word> GetSimilarWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();

                results = dbContext.Wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.Wn_similar,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.Wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => w)
                                .Where(p => p.word != word)
                                .ToList();

                return results;
            }
        }

        public List<wn_word> GetAntonymWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();
                results = dbContext.Wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.Wn_antonym,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.Wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => w)
                                .Where(p => p.word != word)
                                .ToList();

                return results;
            }
        }

        public List<string> GetVerbFrame_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<string> results = new List<string>();

                var temp = dbContext.Wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.Wn_verb_frame,
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

        public List<wn_word> GetDerivedWord_ByWord(string word)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();

                results = dbContext.Wn_word
                                .Where(p => p.word.Equals(word))
                                .Join(
                                    dbContext.Wn_derived,
                                    w => w.synset_id,
                                    a => a.synset_id_1,
                                    (w, a) => new { a.synset_id_2 })
                                .Join(
                                    dbContext.Wn_word,
                                    wa => wa.synset_id_2,
                                    w => w.synset_id,
                                    (wa, w) => w)
                                .Where(p => p.word.Contains(word))
                                .ToList();

                results = results.GroupBy(p => p.word)
                        .Select(p => p.First())
                        .ToList();

                return results;
            }
        }

        public List<decimal> GetHypernymSynsetID_BySynsetID_Recur(decimal id)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                List<decimal> results = new List<decimal>();

                results = dbContext.Wn_hypernym
                            .Where(p => p.synset_id_2 == id)
                            .Select(p => p.synset_id_1)
                            .ToList();

                foreach (decimal s in results)
                {
                    results.Union(GetHypernymSynsetID_BySynsetID_Recur(s));
                }

                return results;
            }
        }

        public List<string> GetDefinition_ByWord(string word)
        {
            word = word.Replace(' ', '_');

            string txtString = string.Empty;
            string[] result = new string[4] { "", "", "", "" }; // 0 : verb, 1: noun, 2: adj, 3: adv
            foreach (wn_synset ss in GetSynset_ByWord(word))
            {
                int j = 0;
                int i = ss.definition.IndexOf(';');
                if (i == -1)
                    txtString += ss.definition + ".\n\n";
                else
                    txtString += ss.definition.Substring(j, i) + ".\n\n";

                while (true)
                {
                    j = i;
                    i = ss.definition.IndexOf(';', i + 1);

                    if (i == -1)
                        break;

                    string sentence = "";
                    if (i == -1)
                        sentence = ss.definition.Substring(j + 2);
                    else
                        sentence = ss.definition.Substring(j + 2, i - j - 2);

                    if (sentence.Contains(word))
                    {
                        txtString += "\t• " + sentence.Trim('"') + ".\n\n";
                    }
                }

                int synsetType = (int)ss.synset_id / 100000000;
                result[synsetType - 1] += txtString;

                txtString = string.Empty;
            }

            return result.ToList();
        }


        public List<Topic> GetTopic_All()
        {
            using (var dbContext = new DictionaryContext())
            {
                List<Topic> results = new List<Topic>();

                results = dbContext.Topic
                                .ToList();

                return results;
            }
        }

        public Topic GetTopic_ByTopicID(decimal topicID)
        {
            using (var dbContext = new DictionaryContext())
            {
                Topic results = new Topic();

                results = dbContext.Topic
                        .Where(p => p.TopicID == topicID)
                        .First();

                return results;
            }
        }

        public List<Topic> GetTopic_ByFilter(string filter)
        {
            using (var dbContext = new DictionaryContext())
            {
                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                List<Topic> results = new List<Topic>();

                results = dbContext.Topic
                        .Where(p => startWith && endWith ? p.TopicName.Contains(filter) :
                                startWith ? p.TopicName.StartsWith(filter) :
                                endWith ? p.TopicName.EndsWith(filter) :
                                p.TopicName.Equals(filter))
                        .ToList();

                return results;
            }
        }

        public List<Branch> GetBranch_ByTopicID(decimal topicID)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<Branch> results = new List<Branch>();

                results = dbContext.Branch
                                .Where(p => p.TopicID == topicID)
                                .ToList();

                return results;
            }
        }

        public Branch GetBranch_BySynsetID(decimal synsetID)
        {
            using (var dbContext = new DictionaryContext())
            {
                Branch results = new Branch();

                results = dbContext.Branch
                                .Where(p => p.SynsetID == synsetID)
                                .First();

                return results;
            }
        }

        public List<wn_word> GetTopicWord_BySynsetID(decimal synsetID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();

                List<decimal> s1s = GetHypernymSynsetID_BySynsetID_Recur(synsetID);

                var temp = dbContext.Wn_word
                                .Where(p => s1s.Contains(p.synset_id))
                                .Select(p => p.word)
                                .Distinct()
                                .ToList();

                temp.ForEach(item =>
                {
                    results.Add(new wn_word() { synset_id = synsetID, word = item });
                });

                return results;
            }
        }

        public bool AddTopic(Topic topic)
        {
            try
            {
                using (DictionaryContext dbContext = new DictionaryContext())
                {
                    topic.TopicName = topic.TopicName.Replace(' ', '_');

                    dbContext.Topic.Add(topic);
                    dbContext.Branch.AddRange(topic.Branches);

                    dbContext.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool UpdateTopic(Topic topic)
        {
            try
            {
                using (DictionaryContext dbContext = new DictionaryContext())
                {
                    topic.TopicName = topic.TopicName.Replace(' ', '_');

                    var found = dbContext.Topic
                                .Single(p => p.TopicID == topic.TopicID);

                    found.TopicName = topic.TopicName;
                    found.Background = topic.Background;

                    var temp = dbContext.Branch
                        .Where(p => p.TopicID == topic.TopicID)
                        .ToList();

                    dbContext.Branch.RemoveRange(temp);
                    dbContext.Branch.AddRange(topic.Branches);
                    dbContext.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteTopic(int topicID)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                var temp = dbContext.Branch
                        .Where(p => p.TopicID == topicID)
                        .ToList();

                dbContext.Branch.RemoveRange(temp);
                dbContext.Topic.Remove(dbContext.Topic.Single(p => p.TopicID == topicID));

                dbContext.SaveChanges();
            }
        }

        public bool CheckTopicNameIsExist(string topic)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                var temp = dbContext.Topic
                    .Where(p => p.TopicName == topic)
                    .ToList();

                return temp.Count != 0;

            }
        }

    }
}
