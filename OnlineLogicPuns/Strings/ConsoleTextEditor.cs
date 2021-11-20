using System.Collections.Generic;

namespace OnlineLogicPuns
{
    public class ConsoleTextEditor
    {
        public string[] textEditor1_2(string[][] queries)
        {
            List<string> result = new List<string>();
            int cursorIndex = 0;
            int selectionEnd = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                string action = queries[i][0];
                if (action == "APPEND")
                {
                    result.Add(ProcessAppend(queries[i][1], result.ToArray(), i, cursorIndex, selectionEnd));
                }
                if (action == "MOVE")
                {
                    int.TryParse(queries[i][1], out cursorIndex);
                }
                if (action == "BACKSPACE")
                {
                    result[i] = result[i].Substring(0, cursorIndex) + result[i].Substring(cursorIndex + 1);
                }
                if (action == "SELECT")
                {
                    int.TryParse(queries[i][1], out cursorIndex);
                    int.TryParse(queries[i][2], out selectionEnd);
                }

            }
            return result.ToArray();
        }

        string ProcessAppend(string text, string[] result, int i, int cursorIndex, int selectionEnd)
        {
            if (i == 0)
            {
                return text;
            }
            string pre;
            string post;
            if (cursorIndex == selectionEnd)
            {
                if (cursorIndex == 0)
                {
                    return result[i - 1] + text;
                }
                pre = result[i - 1].Substring(0, cursorIndex);
                 post = result[i - 1].Substring(cursorIndex + 1);
                return pre + text + post;
            }

            pre = result[i - 1].Substring(0, cursorIndex);
            post = result[i - 1].Substring(selectionEnd + 1);
            return pre + text + post;
        }
    }
}
