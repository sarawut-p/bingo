using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            BingoTable bingoTable = new BingoTable();

            Console.WriteLine(bingoTable.IsBingo(new int[] { 3,4,8,13,18,19,23}));
            Console.WriteLine(bingoTable.IsBingo(new int[] { 1,13,19,25,23,2}));
            Console.WriteLine(bingoTable.IsBingo(new int[] { 2,1,12,15,6,18,16,4,3,21,11 }));
        }
    }
}
