using System;

namespace App {

    public class Birthday {

        public static void SetBirthday() 
        {

            Console.WriteLine("Enter Birthday Month: ");
            int? birthdayMonth = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Current Month: ");
            int? currentMonth = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Enter Your Birth Date: ");
            int? birthdayDaye = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Current Day: ");
            int? currentDay = Convert.ToInt16(Console.ReadLine());

            int? dates = birthdayMonth - currentMonth;
            int? days = birthdayDaye - currentDay;

            Console.WriteLine($"Your Birthday is in: {dates} Month");


            Console.WriteLine($"Your Birthday is in: {days} Days");
            
            Console.ReadLine();

        } 


    }
}