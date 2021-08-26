
using System.Collections.Generic;
using System.Text;

namespace OnlineLogicPuns
{
    /**
        Top K Frequently Mentioned Keywords 
    */
    public class TopKMostFrequent
    {
        public string[] FindTopKMostWantedKeywords(int k, string[] keyWords, string[] reviews)
        {
            string[] topKMostWantedKeyWords = new string[k];
            IDictionary<string, int> mostWantedCounters = new Dictionary<string, int>();
            foreach(string keyWord in keyWords){
                mostWantedCounters.Add(keyWord, 0);
            }
            Dictionary<int,List<string>> currentMostWanted = new Dictionary<int, List<string>>();
            int max = 0;
            foreach (string review in reviews)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (char ch in review)
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
                        if (mostWantedCounters.ContainsKey(word)){
                            mostWantedCounters[word]++;
                            if (!currentMostWanted.TryGetValue(mostWantedCounters[word], out List<string> listedWords))
                            {                                
                                listedWords = new List<string>(); 
                                listedWords.Add(word);
                                currentMostWanted.Add(mostWantedCounters[word], listedWords);
                                int mostWantedCounter = mostWantedCounters[word];
                                if (mostWantedCounter > max){
                                    max = mostWantedCounters[word];
                                }
                            }   
                            else
                            {
                                listedWords.Add(word);                                
                                currentMostWanted[mostWantedCounters[word]] =  listedWords;
                            }
                            break;
                        }
                    }
                }
            }
            List<string> result = new List<string>();
            while ( k >= 0){                
                List<string> tempResult = currentMostWanted[k];
                k = k - result.Count;            
                result.AddRange(tempResult);
            }

            return result.ToArray();
        }
    }
}