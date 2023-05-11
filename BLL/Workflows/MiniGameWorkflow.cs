using BLL.Components;
using BLL.TransferObjects;
using BLL.Workflows;
using EFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        private NotebookManager _NotebookManager;
        private EDictionaryMananger _EDictionaryManager;

        public MiniGameWorkflow()
        {
            _NotebookManager = new NotebookManager();
            _EDictionaryManager = new EDictionaryMananger();
        }

        public List<QnA> GetWordFor_Game1()
        {
            Random rand = new Random();
            List<QnA> result = new List<QnA>();

            List<string> answerList = GetAnswers(40);

            int TAnsIndex = 0; // 0 - 9
            int FAnsIndex = 10; // 10 - 39

            for (int i = 0; i < 10; ++i)
            {
                QnA qna = new QnA();

                List<string> wrongAnswer = new List<string>();
                for (int k = 0; k < 3; ++k)
                    wrongAnswer.Add(answerList[FAnsIndex + k].Replace('_', ' '));

                qna.RightAnswerIndex = rand.Next(4);
                qna.Answers.AddRange(wrongAnswer);
                qna.Answers.Insert(qna.RightAnswerIndex, answerList[TAnsIndex].Replace('_', ' '));

                List<wn_synset> defs = _EDictionaryManager.GetSynset_ByWord(answerList[TAnsIndex]);
                qna.Question = defs[rand.Next(defs.Count)].definition;

                if (qna.Question.Contains(";")) // remove example
                {
                    int removeIndex = qna.Question.IndexOf(';');
                    qna.Question = qna.Question.Substring(0, removeIndex);
                }

                TAnsIndex += 1;
                FAnsIndex += 3;
                result.Add(qna);

            }
            return result;
        }
        public List<QnA> GetWordFor_Game2()
        {
            List<QnA> result = new List<QnA>();
            Random rand = new Random();

            List<string> answerlist = GetAnswers(20);
            for (int i = 0; i < answerlist.Count; ++i)
            {
                QnA qna = new QnA();

                List<string> similarList = _EDictionaryManager.GetSynonymWord_ByWord(answerlist[i])
                    .Select(p => p.word).ToList();

                string similarWord;

                if (similarList.Count != 0)
                    similarWord = similarList[rand.Next(similarList.Count)];
                else
                    similarWord = "None of above";

                qna.Question = answerlist[i].Replace('_', ' ');
                qna.Answers.Add(similarWord.Replace('_', ' '));
                qna.RightAnswerIndex = 0;

                result.Add(qna);
            }
            return result;
        }

        private List<string> GetAnswers(int count)
        {
            int accountID = LoginWorkflow.Instance.GetAccount().AccountID;
            List<string> result = _NotebookManager.GetNotebookWord_Random(accountID, count)
                .Select(p => p.Word)
                .ToList();

            if (result.Count < count)
            {
                result.AddRange(_EDictionaryManager.GetWord_Random(count)
                    .Select(p => p.word)
                    .ToList());

                result.RemoveRange(count, result.Count - count);
            }

            return result;
        }
    }
}
