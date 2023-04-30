using BLL.Components;
using BLL.TransferObjects;
using BLL.Workflows;
using EFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLLibrary
{
    public class MiniGameWorkflow
    {
        private static MiniGameWorkflow _Instance;
        public static MiniGameWorkflow Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MiniGameWorkflow();
                return _Instance;
            }
        }
        public MiniGameWorkflow()
        {

        }

        public List<QnA> GetWordFor_Game1()
        {
            int accountID = LoginWorkflow.Instance.GetAccount().AccountID;
            DataManager dm = new DataManager();
            List<QnA> qnaList = new List<QnA>();
            Random rand = new Random();
            List<wn_word> wordList = dm.NotebookManager.GetNotebookWord_ForMinigame(accountID, 40);
            
            if (wordList.Count < 40)
                wordList.AddRange(dm.EDictionaryManager.GetWord_Random(40));
            wordList.RemoveRange(40, wordList.Count - 40);

            int TAnsIndex = 0;
            int FAnsIndex = 10;

            for (int i = 0; i < 10; ++i)
            {
                int rightAnswerIndex = rand.Next(4);

                qnaList.Add(new QnA());
                for (int k = 0; k < 4; k++)
                {
                    if (rightAnswerIndex == k)
                    {
                        qnaList[i]._Answers[k] = wordList[TAnsIndex++];
                        qnaList[i]._RightAnswer = qnaList[i]._Answers[k];
                        qnaList[i]._Question = dm.EDictionaryManager.GetSynset_ByWord(qnaList[i]._RightAnswer.word)[0].definition;

                        if (qnaList[i]._Question.Contains(";"))
                        {
                            int removeIndex = qnaList[i]._Question.IndexOf(';');
                            qnaList[i]._Question = qnaList[i]._Question.Substring(0, removeIndex);
                        }
                        qnaList[i]._RightAnswer.word = qnaList[i]._RightAnswer.word.Replace("_", " ");
                    }
                    else
                    {
                        qnaList[i]._Answers[k] = wordList[FAnsIndex++];
                    }

                    qnaList[i]._Answers[k].word = qnaList[i]._Answers[k].word.Replace("_", " ");
                }
            }
            return qnaList;
        }
        public List<Tuple<string, string>> GetWordFor_Game2()
        {
            DataManager dm = new DataManager();
            int accountID = LoginWorkflow.Instance.GetAccount().AccountID;
            List<string> list = dm.NotebookManager.GetNotebookWord_ForMinigame(accountID, 20)
                                                    .Select(x => x.word)
                                                    .ToList();

            list.AddRange(dm.EDictionaryManager.GetWord_Random(40)
                                                .Select(p => p.word)
                                                .ToList());
            list.RemoveRange(20, list.Count - 20);
            List<Tuple<string, string>> results = new List<Tuple<string, string>>();
            for (int i = 0; i < list.Count; ++i)
            {
                List<string> similarList = dm.EDictionaryManager.GetSimilarWord_ByWord(list[i])
                    .Select(p => p.word).ToList();

                string similarWord;

                if (similarList.Count != 0)
                    similarWord = similarList[0];
                else
                    similarWord = "None of above";
                results.Add(new Tuple<string, string>(list[i], similarWord));
            }
            return results;
        }
    }
}
