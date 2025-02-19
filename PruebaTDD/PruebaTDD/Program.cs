using System;

namespace PruebaTDD
{
    public class Program
    {
        public static string NumberVerify(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "SunMoon";
            }
            else if (number % 3 == 0)
            {
                return "Sun";
            }
            else if (number % 5 == 0)
            {
                return "Moon";
            }
            else
            {
                return "No es múltiplo de 3 ni de 5";
            }
        }
    }
}
