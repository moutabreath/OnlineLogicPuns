using System.IO;

namespace OnlineLogicPuns
{
    class EbayDecipher
    {
        private static void Decipher(string text)
        {
            // byte[] bytes =  System.Convert.FromBase64String(text);
            // return Encoding.UTF8.GetString(bytes);
            bool replace = false;
            byte[] b = File.ReadAllBytes(text);
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '\0')
                {
                    if (replace)
                    {
                        //1f8b
                        b[i - 1] = 0x1f;
                        b[i] = 0x8b;
                        replace = false;
                    }
                    else
                    {
                        replace = true;
                    }
                }
                else
                {
                    replace = false;
                }
            }
            string ans = System.Convert.ToBase64String(b);
        }

    }
}
