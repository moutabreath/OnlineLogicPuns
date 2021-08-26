using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OnlineLogicPuns
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MostCommonWordSolver
    {
        public string FindMostCommonWord(string paragraph, string[] banned)
        {
            IDictionary<string, int> wordsCounters = AddBannedToDictionary(banned);
            int maxCommon = 0;
            string mostCommonWord = "";
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char ch in paragraph)
            {
                if (ch != ' ')
                {
                    if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                    {
                        stringBuilder.Append(ch);
                    }
                }
                else
                {       
                    string word = stringBuilder.ToString().ToLower();
                    stringBuilder = new StringBuilder();
                    if (wordsCounters.TryGetValue(word, out int currentCounter))
                    {
                        if (currentCounter == -1) continue;

                        currentCounter++;
                        wordsCounters[word] = currentCounter;
                        if (currentCounter > maxCommon)
                        {
                            maxCommon = currentCounter;
                            mostCommonWord = word;
                        }
                    }
                    else
                    {
                        wordsCounters.Add(word, 1);
                    }
                }
            }
            return mostCommonWord;
        }

        private IDictionary<string, int> AddBannedToDictionary(string[] banned)
        {
            IDictionary<string, int> wordsCounters = new Dictionary<string, int>();
            foreach (string bannedWord in banned)
            {
                if (!wordsCounters.ContainsKey(bannedWord))
                {
                    wordsCounters.Add(bannedWord, -1);
                }
            }
            return wordsCounters;
        }


        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}