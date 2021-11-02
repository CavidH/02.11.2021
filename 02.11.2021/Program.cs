
using System;
using System.Linq;
using System.Text;

namespace _02._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Split
            string InputStr = "sdf-sdsffsdf-dsf-sdf-sdf-ds-f-sd-f-dsf-sd-f-sdfm sdf";
            foreach (var item in Split('-', InputStr))
            {
                Console.WriteLine(item);
            }
            #endregion

            #region join
            string[] Input = { "salam", "necesen", "mende", "hello", "yazsiyam " };
            Console.WriteLine(string.Join("-", Input));
            Console.WriteLine(Join("-", Input));
            #endregion

        }
        public static string[] Split(char Separator,string Value )
        {
            int count=1;
            int count1 = 0;
            for (int i = 0; i < Value.Length; i++)
            {
                if (Value[i]==Separator)
                { 
                    count++;
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            string[] Result = new string[count];
            for (int i = 0; i < Value.Length; i++)
            {
                if (Value[i]!=Separator)
                {
                    stringBuilder.Append(Value[i]);
                }

                if (Value[i] == Separator || i==Value.Length-1)
                {
                    Result[count1] = stringBuilder.ToString();
                    stringBuilder.Clear();
                    count1++;
                }
            }


            return Result;
            
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
