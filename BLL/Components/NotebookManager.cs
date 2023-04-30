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
                var rs = db.Notebook.Where(p => p.AccountID == userID
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
                    var w = db.Wn_word
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
                        db.Notebook.Add(notebook);

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
                    var rs = db.Notebook
                        .Where(p => p.Wn_Word.word.Equals(word) && p.AccountID == userID)
                        .FirstOrDefault();
                    db.Notebook.Remove(rs);
                    db.SaveChanges();
                }
            }
        }

        public List<NotebookCard> GetNotebookWord_All(int userID)
        {
            using (var db = new DictionaryContext())
            {
                List<NotebookCard> result = new List<NotebookCard>();

                List<Notebook> temps = db.Notebook
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
                    temps = db.Notebook
                        .Where(w => w.AccountID == userID)
                        .OrderBy(w => w.LearnedPercent)
                        .ToList();

                }
                else
                {
                    temps = db.Notebook.Where(w => w.AccountID == userID)
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
        public void Update_LearnedPercent(int userID, string word, int num)
        {
            using (var db = new DictionaryContext())
            {
                var rs = db.Notebook
                    .Where(x => x.Wn_Word.word == word)
                    .FirstOrDefault();

                if (rs == null)
                    return;

                rs.LearnedPercent += num;
                db.SaveChanges();

                if (rs.LearnedPercent >= 100)
                    RemoveWord(userID, rs.Wn_Word.word);
            }
        }
        public List<wn_word> GetNotebookWord_ForMinigame(int userID, int limit)
        {
            using (var db = new DictionaryContext())
            {
                List<wn_word> results = new List<wn_word>();
                List<string> Wn_words = new List<string>();
                Random rand = new Random();

                List<Notebook> temps = db.Notebook.AsEnumerable()
                    .OrderBy(x => rand.Next()).Take(limit).ToList();

                temps.ForEach(item =>
                {
                    Wn_words.Add(item.Wn_Word.word);
                });

                Wn_words.ForEach(item =>
                {
                    wn_word newWord = new wn_word();
                    newWord.word = item;
                    results.Add(newWord);
                });
                return results;
            }
        }
        public int GetNotebookCount(int userID)
        {
            using (var db = new DictionaryContext())
            {
                return db.Notebook.Count();
            }
        }
    }
}
