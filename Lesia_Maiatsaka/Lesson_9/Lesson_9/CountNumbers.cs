using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    public class CountNumbers
    {
        private IEnumerable<int> _numbers;

        public CountNumbers(IEnumerable<int> numbers)
        {
            _numbers = numbers;
        }

        public IEnumerable<int> GetPositiveNumbers() 
        {
            return _numbers.Where(x => x > 0);
        }
        public IEnumerable<int> GetNegativeNumbers()
        {
            return _numbers.Where(x => x < 0);
        }

        public int SmallestNumber() 
        {
            return _numbers.Min();
        }

        public int LargestNumber()
        {
            return _numbers.Max();
        }
        public int SumOfElements() 
        {
            return _numbers.Sum();
        }
        public int FirstBelowAverage() 
        {
            var average = _numbers.Average();
            return _numbers.Where(x => x < average)
                .OrderByDescending(e => e)
                .FirstOrDefault();
        }
        public IEnumerable<int> OrderBy() 
        {
            return _numbers.OrderBy(x => x);
        }
    }
}
