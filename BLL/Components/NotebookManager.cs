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
                        .Where(p => p.Wn_Word.word.Equals(word) && p.AccountID == userID)
                        .FirstOrDefault();
                    db.notebook.Remove(rs);
                    db.SaveChanges();
                }
            }
        }

        public List<NotebookCard> GetNotebookWord_All(int userID)
        {
            using (var db = new DictionaryContext())
            {
                List<NotebookCard> result = new List<NotebookCard>();

                List<Notebook> temps = db.notebook
                    .Where(p => p.AccountID == userID)
                    .ToList();

                temps.ForEach(item =>
                {
                    result.Add(new NotebookCard() { Word = item.Wn_Word.word, LearnedPercent = item.LearnedPercent });
                });

                return result;
            }
        }

        public List<NotebookCard> GetSortedWord_ByPercentLearning(int userID, string order)
        {
            using (var db = new DictionaryContext())
            {
                List<NotebookCard> result = new List<NotebookCard>();
                List<Notebook> temps = new List<Notebook>();

                if (order == "ascending")
                {
                    temps = db.notebook
                        .Where(w => w.AccountID == userID)
                        .OrderBy(w => w.LearnedPercent)
                        .ToList();

                }
                else
                {
                    temps = db.notebook.Where(w => w.AccountID == userID)
                        .OrderByDescending(w => w.LearnedPercent)
                        .ToList();
                }

                temps.ForEach(item =>
                {
                    result.Add(new NotebookCard() { Word = item.Wn_Word.word, LearnedPercent = item.LearnedPercent });
                });

                return result;
            }

        }

        public int GetNotebookCount(int userID)
        {
            using (var db = new DictionaryContext())
            {
                return db.notebook.Count();
            }
        }
    }
}
