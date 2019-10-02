using System;
namespace ZodiacSign {
    class MainClass {
        static void Main(string[] args) {
            string b_date;
            string result = null;
            string[] array;
            string[] sign = new [] {"Kozerog", "Vodolei", "Fish", "Oven", "Teletc", "Gemini", "Rak", "Lion", "Deva", "Vesi", "Scorpio", "Streletc", "Kozerog" };
            int[] s_date = new[] {22,21,19,21,21,21,21,21,23,23,23,23,22} ;
            // Даты начала периода каждого знака, взяты из древнего гороскопа.
            int day;
            int month;
            while (true) {
                try
                {
                    Console.WriteLine("Enter birthday date DD.MM or D.M.\nEnter Q to quit the program.");
                    b_date = (Console.ReadLine()).Replace(",", ".");
                    if (b_date == "Q" || b_date == "q")
                        break;
                    array = b_date.Split('.');
                    day = int.Parse(array[0]);
                    month = int.Parse(array[1]);
                    if (day >= s_date[month]) { result = sign[month]; }
                    else if (day < s_date[month]) { result = sign[month - 1]; }
                    Console.WriteLine($"Your zodiac sign is:{result}\n");
                }
                catch (Exception) {
                    Console.WriteLine("Wrong input, try again.\n");
                }
                finally { }
            }
        }
    }
}
