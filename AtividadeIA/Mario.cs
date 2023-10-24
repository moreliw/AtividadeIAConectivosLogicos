using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeIA
{
    class Program
    {
        static void Main()
        {
            bool choveu = false;
            bool surfou = false;
            bool correu = true;

            if (!choveu)
            {
                surfou = true;
            }

            if (surfou || correu)
            {
                if (surfou && correu)
                {
                    Console.WriteLine("Mario surfou e correu.");
                }
                else if (surfou)
                {
                    Console.WriteLine("Mario surfou.");
                }
                else
                {
                    Console.WriteLine("Mario correu.");
                }
            }
            else
            {
                Console.WriteLine("Mario não surfou nem correu.");
            }
        }
    }

}
