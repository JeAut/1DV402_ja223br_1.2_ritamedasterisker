using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row <= 24; row++)
            {
             switch (row % 3)
             {
                 case 0:
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     break;

                 case 1:
                     Console.ForegroundColor = ConsoleColor.Magenta;
                     break;

                 case 2:
                     Console.ForegroundColor = ConsoleColor.Green;
                     break;
             }
                     for (int col = 0; col <= 39; col++)
                     {
                         Console.Write("* ");
                     }

                     Console.WriteLine("");


                     
                     if (row % 2 == 0)
                     {
                         Console.Write(" ");
                     }

                     Console.ResetColor();
            } 

        }
    }
}
