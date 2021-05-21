using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure
{
    class TestingThings
    {
        public int GetAnInt()
        {
            while (true)
            {
                string inmatning = Console.ReadLine();
                int resultatet;

                if (int.TryParse(inmatning, out resultatet) == true)
                {
                    return resultatet;
                }
                Console.WriteLine("Mata in ett TAL tack");
            }
        }
        public decimal GetAnDecimal()
        {
            while (true)
            {
                string inmatning = Console.ReadLine();
                decimal resultatet;

                if (decimal.TryParse(inmatning, out resultatet) == true)
                {
                    return resultatet;
                }
                Console.WriteLine("Mata in ett TAL tack");
            }
        }
    }
}
