using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
            string vysledok = "odd";
            if (number % 2 == 0)
            { vysledok = "even"; };
            return vysledok;
        }
    }
}
