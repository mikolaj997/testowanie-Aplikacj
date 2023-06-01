using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieAplikacj
{
    public class dominanta1
    {
        public int FindDominanta(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }

            int maxFrequency = frequencyMap.Values.Max();
            int dominanta = frequencyMap.First(kvp => kvp.Value == maxFrequency).Key;

            return dominanta;
        }
    }

}
