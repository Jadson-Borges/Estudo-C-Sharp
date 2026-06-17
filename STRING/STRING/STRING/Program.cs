using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin = "abcd EFGH LJM nop QRSTU   ";

            string s1 = origin.ToUpper();
            string s2 = origin.ToLower();
            string s3 = origin.Trim();

            int s4 = origin.IndexOf("cd");
            int s5 = origin.LastIndexOf("GH");

            string s6 = origin.Substring(3);
            string s7 = origin.Substring(3, 5);

            string s8 = origin.Replace('a', 'x');
            string s9 = origin.Replace("abc", "wxyz");

            bool b1 = string.IsNullOrEmpty(origin);
            bool b2 = string.IsNullOrWhiteSpace(origin);

            Console.WriteLine("Original: " + origin);
            Console.WriteLine("ToUpper: " + s1 + "-");
            Console.WriteLine("ToLower: " + s2 + "-");
            Console.WriteLine("Trim: " + s3 + "-");
            Console.WriteLine("IndexOF ('cd')" + s4);
            Console.WriteLine("LastIndexOF ('GH')" + s5);
            Console.WriteLine("Substring 3: " +s6);
            Console.WriteLine("Substring 3: " +s7);
            Console.WriteLine("Replace : (troque 'a' por 'x'): " + s8 + " -");
            Console.WriteLine("Replace : (troque 'abc' por 'wxyz''): " + s9 + " -");
            Console.WriteLine("IsNullOrEmpty " + b1);
            Console.WriteLine("IsNullOrWhiteSpace " + b2);
        }
    }
}
