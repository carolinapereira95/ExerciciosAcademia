using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Domain
{
    public class FatorialNumber
    {
        public int Number { get; set; }

        public FatorialNumber(int number)
        {
            Number = number;
        }

        public int FatorialNumberCalculator (int number)
        {
            int fatorial = 1;
            if (number<0 || number >30)
                throw new Exception("The number is out of limits!");
            for(int i=number; i<=1; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
