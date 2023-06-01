using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieAplikacj
{
    public class NWD
    {
        public static int FindNWD(int n, int m)
        {
            int roznica = Math.Abs(n - m);
            while (roznica > 0)
            {
                if (n > m)
                {
                    n = roznica;
                }
                else
                {
                    m = roznica;
                }

                roznica = Math.Abs(n - m);
            }

            return n > m ? m : n;
        }
    }

}
