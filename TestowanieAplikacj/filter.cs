using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieAplikacj
{
    public class filter
    {
        public static void Main(string[] args)
        {
            filter p = new filter();
            List<int> input = new List<int>() { 1, 2, 2, 3, 5, 7, 9, 8, 2 };
            List<int> result = p.Filter(input);
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
        }

        public List<int> Filter(List<int> list)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

    }
}
