using System;
using System.Threading;

namespace App
{
    class Program
    {
        
        private static float Wage = 0;
        private static float Hours = 0;
        private static float Days = 0;
        private static float Weeks = 0;
        private static float Calculation = 0;

        private static bool IsEmpty(float a)
        {
            if (a == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public static void Main(string[] args)
        {
            if (Wage.Equals(null)) return;
            if (Hours.Equals(null)) return;
            if (Days.Equals(null)) return;
            if (Weeks.Equals(null)) return;
         
            
            Console.WriteLine("Enter Wage? ");
            Wage = float.Parse(Console.ReadLine());
            if (IsEmpty(Wage))
            {
                Console.WriteLine("Empty...");
            }
            
            Console.WriteLine("Enter Hours Worked? ");
            Hours = float.Parse(Console.ReadLine());

            if (IsEmpty(Hours))
            {
                Console.WriteLine("Empty...");
            }
            
            Console.WriteLine("Enter Days Worked? ");
            Days = int.Parse(Console.ReadLine());
            if (IsEmpty(Days))
            {
                Console.WriteLine("Empty...");
            }
            
            Console.WriteLine("Ener Weeks? ");
            Weeks = int.Parse(Console.ReadLine());
            
            if (IsEmpty(Weeks))
            {
                Console.WriteLine("Empty...");
            }

            
            Calculation = Wage * Hours * Days * Weeks;
            
            Console.WriteLine($"You Will Make? ${Calculation} a Year");
            Console.ReadLine();
            
            Thread.Sleep(2000);            
            
        }
        
    }
};

