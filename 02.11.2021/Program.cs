
using System;
using System.Linq;
using System.Text;

namespace _02._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "salam", "necesen", "mende", "hello", "yazsiyam " };
            Console.WriteLine(string.Join("-", s));
            Console.WriteLine(Join("-",s));
        }

        public static string Join(string Sep, string[] Value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Value.Length-1; i++)
            {
                stringBuilder.Append(Value[i] + Sep);
            }
            stringBuilder.Append(Value[Value.Length-1]);
            return stringBuilder.ToString();
        }
    }
}
