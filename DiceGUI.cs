using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace CIKuppgift3
{
    public class DiceGUI
    {
        private string[] _row = new string[5];

    public DiceGUI()
        {
            for (var i = 0; i < 5; i++)
            {
                _row[i] = " ";
            }
        }

        public void PrintRandomRolls(int sides)
        {
            Clear();
            for (int i = 0; i < 5; i++)
            {
                var num = new Dice(sides).Roll();
                PrintNumber(num);
                Thread.Sleep(600 - 100*i);
                Clear();
            }
        }

        public void PrintNumber(IEnumerable<int> number)
        {
            foreach (var num in number)
            {
                switch (num)
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
            for (var i = 0; i < 5; i++)
            {
                var rowtoprint = string.Concat(_row[i]);
                Console.WriteLine(rowtoprint);
            }
        }
        public void Clear()
        {
            Console.Clear();
            for (var i = 0; i < 5; i++)
            {
                _row[i] = " ";
            }
        }

        private void Print1()
        {
            _row[0] += "    ## ";
            _row[1] += "    ## ";
            _row[2] += "    ## ";
            _row[3] += "    ## ";
            _row[4] += "    ## ";
        }
        private void Print2()
        {
            _row[0] += "###### ";
            _row[1] += "    ## ";
            _row[2] += "###### ";
            _row[3] += "##     ";
            _row[4] += "###### ";
        }
        private void Print3()
        {
            _row[0] += "###### ";
            _row[1] += "    ## ";
            _row[2] += "###### ";
            _row[3] += "    ## ";
            _row[4] += "###### ";
        }
        private void Print4()
        {
            _row[0] += "##  ## ";
            _row[1] += "##  ## ";
            _row[2] += "###### ";
            _row[3] += "    ## ";
            _row[4] += "    ## ";
        }
        private void Print5()
        {
            _row[0] += "###### ";
            _row[1] += "##     ";
            _row[2] += "###### ";
            _row[3] += "    ## ";
            _row[4] += "###### ";
        }
        private void Print6()
        {
            _row[0] += "###### ";
            _row[1] += "##     ";
            _row[2] += "###### ";
            _row[3] += "##  ## ";
            _row[4] += "###### ";
        }
        private void Print7()
        {
            _row[0] += "###### ";
            _row[1] += "    ## ";
            _row[2] += "    ## ";
            _row[3] += "    ## ";
            _row[4] += "    ## ";
        }
        private void Print8()
        {
            _row[0] += "###### ";
            _row[1] += "##  ## ";
            _row[2] += "###### ";
            _row[3] += "##  ## ";
            _row[4] += "###### ";
        }
        private void Print9()
        {
            _row[0] += "###### ";
            _row[1] += "##  ## ";
            _row[2] += "###### ";
            _row[3] += "    ## ";
            _row[4] += "###### ";
        }
        private void Print0()
        {
            _row[0] += "###### ";
            _row[1] += "##  ## ";
            _row[2] += "##  ## ";
            _row[3] += "##  ## ";
            _row[4] += "###### ";
        }
    }
}
