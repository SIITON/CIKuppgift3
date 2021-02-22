using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace CIKuppgift3
{
    public class DiceGUI
    {
        public DiceGUI()
        {
        }

        public void PrintRandomRolls(int sides)
        {
            Clear();
            for (int i = 0; i < 5; i++)
            {
                var num = new Dice(sides).Roll();
                PrintNumber(num);
                Thread.Sleep(500);
                Clear();
            }
        }

        public void PrintNumber(int number)
        {
            switch (number)
            {
                case 1:
                    Print1();
                    break;
                case 2:
                    Print2();
                    break;
                case 3:
                    Print3();
                    break;
                case 4:
                    Print4();
                    break;
                case 5:
                    Print5();
                    break;
                case 6:
                    Print6();
                    break;
                case 7:
                    Print7();
                    break;
                case 8:
                    Print8();
                    break;
                case 9:
                    Print9();
                    break;
                case 0:
                    Print0();
                    break;
            }
        }
        public static void Clear()
        {
            Console.Clear();
        }

        private static void Print1()
        {
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
        }
        private static void Print2()
        {
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("######");
            Console.WriteLine("##    ");
            Console.WriteLine("######");
        }
        private static void Print3()
        {
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("######");
        }
        private static void Print4()
        {
            Console.WriteLine("##  ##");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
        }
        private static void Print5()
        {
            Console.WriteLine("######");
            Console.WriteLine("##    ");
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("######");
        }
        private static void Print6()
        {
            Console.WriteLine("######");
            Console.WriteLine("##    ");
            Console.WriteLine("######");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
        }
        private static void Print7()
        {
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
        }
        private static void Print8()
        {
            Console.WriteLine("######");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
        }
        private static void Print9()
        {
            Console.WriteLine("######");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
            Console.WriteLine("    ##");
            Console.WriteLine("    ##");
        }
        private static void Print0()
        {
            Console.WriteLine("######");
            Console.WriteLine("##  ##");
            Console.WriteLine("##  ##");
            Console.WriteLine("##  ##");
            Console.WriteLine("######");
        }
    }
}
