namespace Exercicio2.Domain
{

    using System;

    public class PerfectNumber
    {
        public int Number { get; set; }

        public PerfectNumber(int number)
        {
            Number = number;
        }

        public bool VerifyNumberIsPerfect (int number)
        {
            if (number < 0 || number > 1000)
                throw new Exception("The number is out of limits!");
            else
            {
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    if (number % i == 0)
                        sum += i;
                }
                return sum == number;
            }
        }
    }
}
