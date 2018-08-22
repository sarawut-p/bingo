using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class BingoTable
    {
        public const int TABLE_SIZE = 5;

        public bool IsBingo(IEnumerable<int> inputs)
        {
            return this.isSameColumnBingo(inputs) ||
                   this.isSameRowBingo(inputs) ||
                   this.isLeftDiagonalBingo(inputs) ||
                   this.isRightDiagonalBingo(inputs);                   
        }

        private bool isSameColumnBingo(IEnumerable<int> inputs)
        {
            var groupedByColumnIndex = inputs.GroupBy(input => input % TABLE_SIZE);
            var anyFullColumn = groupedByColumnIndex.Any(grouped => grouped.Count() == TABLE_SIZE);
            return anyFullColumn;
        }

        private bool isSameRowBingo(IEnumerable<int> inputs)
        {
            var groupedByRowIndex = inputs.GroupBy(input => Math.Ceiling( (double)input / (double)TABLE_SIZE));
            var anyFullRow = groupedByRowIndex.Any(grouped => grouped.Count() == TABLE_SIZE);
            return anyFullRow;
        }

        
        private IEnumerable<int> getLeftDiagonalBingo()
        {
            return Enumerable.Range(0, TABLE_SIZE)
                             .Select((index) => 1 + ( (TABLE_SIZE + 1) * index));
        }

        private bool isLeftDiagonalBingo(IEnumerable<int> inputs)
        {
            return getLeftDiagonalBingo().All(item => inputs.Contains(item));
        }

        private IEnumerable<int> getRightDiagonalBingo()
        {
            return Enumerable.Range(0, TABLE_SIZE)
                             .Select((index) => TABLE_SIZE + ((TABLE_SIZE + -1) * index));
        }

        private bool isRightDiagonalBingo(IEnumerable<int> inputs)
        {
            return getRightDiagonalBingo().All(item => inputs.Contains(item));
        }
    }
}
