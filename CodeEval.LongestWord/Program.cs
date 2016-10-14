using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval.LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineOne = "some line with test";
            string lineTwo = "another line";

            int longWord1 = lineOne.Length;
            string[] longWord11 = lineOne.Split(' ');

            string lineOne111 = "";
           
          foreach (string wordline1 in longWord11)
            {
                int lineOneLength = wordline1.Length;
                int lineOneLength2 = lineOne111.Length;
            
            if (lineOneLength>lineOneLength2)
                {
                    lineOneLength2 = lineOneLength;
                    lineOne111 = wordline1;
                }
            }
            
            int longWord2 = lineTwo.Length;
            string[] longWord22 = lineTwo.Split(' ');

            string lineTwo222 = "";

            foreach (string wordline2 in longWord22)
            {
                int lineTwoLength = wordline2.Length;
                int lineTwoLength2 = lineTwo222.Length;


                if (lineTwoLength > lineTwoLength2)
                {
                    lineTwoLength2 = lineTwoLength;
                    lineTwo222 = wordline2;
                }

            }
            Console.WriteLine(lineOne111);
            Console.WriteLine(lineTwo222);
            Console.ReadLine();
          
                       
        }
    }
}
