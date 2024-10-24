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
        
        public static void Main(string[] args)
        {
            if (Wage.Equals(null)) return;
            if (Hours.Equals(null)) return;
            if (Days.Equals(null)) return;
            if (Weeks.Equals(null)) return;
         
            Console.WriteLine("Enter Wage? ");
            Wage = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Hours Worked? ");
            Hours = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Days Worked? ");
            Days = int.Parse(Console.ReadLine());

            Console.WriteLine("Ener Weeks? ");
            Weeks = int.Parse(Console.ReadLine());
            
            Calculation = Wage * Hours * Days * Weeks;
            
            Console.WriteLine($"You Will Make? ${Calculation} a Year");
            Console.ReadLine();
            
            Thread.Sleep(2000);            
            
        }
        
    }
};

