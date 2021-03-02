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
                var num = new Random().Next(1, sides + 1);
                PrintNumber(num);
                Thread.Sleep(600 - 100 * i);
                Clear();
            }
        }

        public void PrintNumber(int number)
        {
            IEnumerable<int> enumerablenumber = number.ToString()
                                                      .Select(x => int.Parse(x.ToString()));
            foreach (var num in enumerablenumber)
            {
                switch (num)
                {
                    case 1:
                        _row[0] += "    ## ";
                        _row[1] += "    ## ";
                        _row[2] += "    ## ";
                        _row[3] += "    ## ";
                        _row[4] += "    ## ";
                        break;
                    case 2:
                        _row[0] += "###### ";
                        _row[1] += "    ## ";
                        _row[2] += "###### ";
                        _row[3] += "##     ";
                        _row[4] += "###### ";
                        break;
                    case 3:
                        _row[0] += "###### ";
                        _row[1] += "    ## ";
                        _row[2] += "###### ";
                        _row[3] += "    ## ";
                        _row[4] += "###### ";
                        break;
                    case 4:
                        _row[0] += "##  ## ";
                        _row[1] += "##  ## ";
                        _row[2] += "###### ";
                        _row[3] += "    ## ";
                        _row[4] += "    ## ";
                        break;
                    case 5:
                        _row[0] += "###### ";
                        _row[1] += "##     ";
                        _row[2] += "###### ";
                        _row[3] += "    ## ";
                        _row[4] += "###### ";
                        break;
                    case 6:
                        _row[0] += "###### ";
                        _row[1] += "##     ";
                        _row[2] += "###### ";
                        _row[3] += "##  ## ";
                        _row[4] += "###### ";
                        break;
                    case 7:
                        _row[0] += "###### ";
                        _row[1] += "    ## ";
                        _row[2] += "    ## ";
                        _row[3] += "    ## ";
                        _row[4] += "    ## ";
                        break;
                    case 8:
                        _row[0] += "###### ";
                        _row[1] += "##  ## ";
                        _row[2] += "###### ";
                        _row[3] += "##  ## ";
                        _row[4] += "###### ";
                        break;
                    case 9:
                        _row[0] += "###### ";
                        _row[1] += "##  ## ";
                        _row[2] += "###### ";
                        _row[3] += "    ## ";
                        _row[4] += "###### ";
                        break;
                    case 0:
                        _row[0] += "###### ";
                        _row[1] += "##  ## ";
                        _row[2] += "##  ## ";
                        _row[3] += "##  ## ";
                        _row[4] += "###### ";
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
    }
}
