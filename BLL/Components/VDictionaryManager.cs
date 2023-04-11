using BLL.TransferObjects;
using EFramework;
using EFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Components
{
    public class VDictionaryManager
    {
        public List<string> GetDefinition_ByWord(string word)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                //danh từ       00
                //nội động từ   01
                //ngoại động từ 02
                //tính từ       03
                //phó từ        04
                List<string> results = new List<string>() { "", "", "", "", "" };

                string HTMLCode = (dbContext.word_viet.Where(i => i.word == word).FirstOrDefault().detail);

                HTMLCode = HTMLCode.Replace("\n", " ");
                HTMLCode = HTMLCode.Replace("\t", " ");
                HTMLCode = Regex.Replace(HTMLCode, "\\s+", " ");
                HTMLCode = Regex.Replace(HTMLCode, "<head.*?</head>", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                HTMLCode = Regex.Replace(HTMLCode, "<script.*?</script>", "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                StringBuilder sbHTML = new StringBuilder(HTMLCode);
                string[] OldWords = { "&nbsp;", "&amp;", "&quot;", "&lt;", "&gt;", "&reg;", "&copy;", "&bull;", "&trade;" };
                string[] NewWords = { " ", "&", "\"", "<", ">", "Â®", "Â©", "â€¢", "â„¢" };
                for (int i = 0; i < OldWords.Length; i++)
                {
                    sbHTML.Replace(OldWords[i], NewWords[i]);
                }
                sbHTML.Replace("<br>", "\n<br>");
                sbHTML.Replace("<br ", "\n<br ");
                sbHTML.Replace("<p ", "\n<p ");

                string text = Regex.Replace(sbHTML.ToString(), "<[^>]*>", "");

                text = text.Replace("\n*", "%\n*");
                text = text.Replace("\n\n@", "%\n\n@");


                string pattern = @"((\*|!)?\s?(danh từ|nội động từ|ngoại động từ|tính từ|phó từ)( & (danh từ|nội động từ|ngoại động từ|tính từ|phó từ))*([\w\s\,]+)?\n[-=]([^%]+(?=%|$)))";

                foreach (Match item in Regex.Matches(text, pattern))
                {
                    string temp = Regex.Replace(item.Value, @"-", "");
                    temp = Regex.Replace(temp, @"=", "\t•");
                    temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                    if (temp.Contains("danh từ"))
                    {
                        results[0] = temp;
                    }
                    if (temp.Contains("nội động từ"))
                    {
                        results[1] = temp;
                    }
                    if (temp.Contains("ngoại động từ"))
                    {
                        results[2] = temp;
                    }
                    if (temp.Contains("tính từ"))
                    {
                        results[3] = temp;
                    }
                    if (temp.Contains("phó từ"))
                    {
                        results[4] = temp;
                    }
                }

                return results;
            }
        }

        public List<WordModel> GetWord_ByFilter(string filter, int limit = 10)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<WordModel> results = new List<WordModel>();
                List<string> words = new List<string>();

                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                words = dbContext.word_viet
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
                    results.Add(new WordModel(item.ToString().Replace('_', ' ')));
                });

                return results;

            }
        }

    }
}
