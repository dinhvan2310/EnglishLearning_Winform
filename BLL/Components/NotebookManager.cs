using BLL.Workflows;
using EFramework.Model;
using EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.TransferObjects;

namespace BLL.Components
{
    public class NotebookManager
    {

        public bool CheckWordIsExistInNotebook(int userID, string word)
        {
            using (var db = new DictionaryContext())
            {
                var rs = db.notebook.Where(p => p.AccountID == userID
                && p.Wn_Word.word.ToLower() == word.ToLower()).FirstOrDefault();
                if (rs == null)
                {
                    return false;
                }
                return true;

            }
        }

        public void AddWord(int userID, string word)
        {
            if (userID != -1)
            {
                using (var db = new DictionaryContext())
                {
                    var w = db.wn_word
                        .Where(p => p.word.ToLower() == word.ToLower())
                        .Select(p => new { p.w_num, p.synset_id })
                        .FirstOrDefault();

                    if (!CheckWordIsExistInNotebook(userID, word))
                    {
                        Notebook notebook = new Notebook()
                        {
                            AccountID = userID,
                            WordNum = w.w_num,
                            SynsetID = w.synset_id,
                            LearnedPercent = 0
                        };
                        db.notebook.Add(notebook);

                        db.SaveChanges();
                    }
                }
            }
        }

        public void RemoveWord(int userID, string word)
        {
            if (userID != -1)
            {
                using (var db = new DictionaryContext())
                {
                    var rs = db.notebook
                        .Where(p => p.AccountID == userID)
                        .ToList();
                    db.notebook.RemoveRange(rs);
                    db.SaveChanges();
                }
            }
        }

        public List<WordModel> GetNotebookWord_All(int userID)
        {

            using (var db = new DictionaryContext())
            {
                List<WordModel> result = new List<WordModel>();

                List<string> words = db.notebook
                    .Where(p => p.AccountID == userID)
                    .Select(p => p.Wn_Word.word.ToLower())
                    .ToList();

                words.ForEach(item =>
                {
                    result.Add(new WordModel(item.ToString()));
                });

                return result;
            }
        }

        public List<WordModel> GetSortedWord_ByPercentLearning(int userID, string order)
        {
            using (var db = new DictionaryContext())
            {
                List<WordModel> result = new List<WordModel>();
                List<string> list = new List<string>();

                if (order == "ascending")
                {
                    var rs = db.notebook
                        .Where(w => w.AccountID == userID)
                        .OrderBy(w => w.LearnedPercent)
                        .ToList();
                    foreach (var i in rs)
                    {
                        var word = db.wn_word
                            .Where(w => w.synset_id == i.SynsetID && w.w_num == i.WordNum)
                            .Select(w => w.word.ToLower());
                        list.AddRange(word);
                    }

                }
                else
                {
                    var rs = db.notebook.Where(w => w.AccountID == userID)
                        .OrderByDescending(w => w.LearnedPercent)
                        .ToList();
                    foreach (var i in rs)
                    {
                        var word = db.wn_word
                            .Where(w => w.synset_id == i.SynsetID && w.w_num == i.WordNum)
                            .Select(w => w.word.ToLower());
                        list.AddRange(word);
                    }
                }

                list.ForEach(item =>
                {
                    result.Add(new WordModel(item.ToString()));
                });

                return result;
            }

        }
    }
}
