using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410002_劉昀叡031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入單字:");
            string str = Console.ReadLine().ToLower();

            if (str.Length < 1 || str.Length > 50)
            {
                Console.WriteLine("請輸入1~50個字之間");
                return;
            }

            string[] words = str.Split(' ');
            Console.WriteLine("要搜尋的英文字母:");
            char x = Console.ReadLine().ToLower()[0];

            List<int> index = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    index.Add(i);
                }
            }
            if (index.Count > 0)
            {
                string result = "[" + String.Join(",", index) + "]";
                Console.WriteLine(result);
            }
            else { string result = "[ ]"; Console.WriteLine(result); }
        }
    }
}
