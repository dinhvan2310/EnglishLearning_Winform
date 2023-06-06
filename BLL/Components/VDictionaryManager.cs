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
                //động từ       01
                //tính từ       02
                //phó từ        03
                //thán từ       04
                //mạo từ        05
                //giới từ       06
                //khác          07
                List<string> results = new List<string>() { "", "", "", "", "", "", "", ""};
                List<string> listString = new List<string>();

                string HTMLCode = (dbContext.Word_viet.Where(i => i.word == word).FirstOrDefault().detail);

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


                string pattern = @"((\*){1}\s([^\n]+)\n[-=!]([^%]+(?=%|$)))";
                MatchCollection matchCollection = Regex.Matches(text, pattern);
                if (matchCollection.Count > 0)
                {
                    foreach (Match item in matchCollection)
                    {
                        if (Regex.IsMatch(item.Value, @"^\*[^=-]+danh từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[0] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+động từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[1] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+tính từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[2] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+phó từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[3] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+thán từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[4] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+mạo từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[5] += temp + "\n";
                        }
                        else if (Regex.IsMatch(item.Value, @"^\*[^=-]+giới từ"))
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[6] += temp + "\n";
                        }
                        else
                        {
                            string temp = Regex.Replace(item.Value, @"-", "");
                            temp = Regex.Replace(temp, @"=", "\t•");
                            temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                            results[7] += temp + "\n";
                        }
                    }
                }
                else
                {
                    string temp = Regex.Replace(text, @"-", "");
                    temp = Regex.Replace(temp, @"=", "\t•");
                    temp = Regex.Replace(temp, @"!", "Cụm từ: ");
                    results[7] += temp + "\n";
                }
                return results;
            }
        }

        /// <summary>
        /// Lấy danh sách các từ việt dựa trên filter 
        /// Có 3 chế độ:
        /// 1.  Lấy danh sách các từ có chứa filter (%filter%)
        /// 2.  Lấy danh sách các từ bắt đầu bằng filter (filter%)
        /// 3.  Lấy danh sách các từ kết thúc bằng filter (%filter)
        /// 4.  Lấy danh sachs các từ giống hệt filter (filter)
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="limit">Số lượng tối đa các từ trả về (mặc định là 10)</param>
        /// <returns></returns>
        public List<word_viet> GetWord_ByFilter(string filter, int limit = 10)
        {
            using (var dbContext = new DictionaryContext())
            {
                List<word_viet> results = new List<word_viet>();

                bool startWith = filter[filter.Length - 1] == '%';
                bool endWith = filter[0] == '%';
                filter = filter.Replace("%", "");

                results = dbContext.Word_viet
                                .Where(w =>
                                    startWith && endWith ? w.word.Contains(filter) :
                                    startWith ? w.word.StartsWith(filter) :
                                    endWith ? w.word.EndsWith(filter) :
                                    w.word.Equals(filter))
                                .Take(limit).ToList();

               /* results = results.GroupBy(p => p.word)
                    .Select(p => p.First())
                    .ToList();*/

                return results;

            }
        }

    }
}
