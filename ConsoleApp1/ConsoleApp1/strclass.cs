using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class strclass
    {
        public string str01(string word)
        {
            
           string [] word1 = word.Split(" ");

            StringBuilder sb = new StringBuilder(); 
            foreach (string word2 in word1)
            {
                sb.Append(str2revers(word2)+" ");
            }

            return sb.ToString();
            
        }
        string str2revers(string wordtex)
        {
            StringBuilder sb = new StringBuilder(); 
            for (int i = wordtex.Length - 1; i >= 0; i--)
            {
                sb.Append(wordtex[i].ToString());
            }

            return sb.ToString();  
        }
    }
}
