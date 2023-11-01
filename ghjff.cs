using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1and11and12();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex17();
            Random rnd = new Random();
            StringBuilder password = new StringBuilder();
            DateTime date = new DateTime(1987, 11, 28);
            if (date > new DateTime(1900, 1, 1) && date < new DateTime(1949, 12, 31))
            {
                password = password.Append("1");
            }
            if (date > new DateTime(1950, 1,1) && date < new DateTime(1999, 12, 31))
            {
                password = password.Append("2");
            }
            if (date > new DateTime(1800,1,1) && date < new DateTime(1849,12,31))
            {
                password = password.Append("3");
            }
            if (date > new DateTime(1850,1,1) && date < new DateTime(1899,12,31))
            {
                password = password.Append("4");
            }
            if (date > new DateTime(2000,1,1) && date < new DateTime(2049,12,31))
            {
                password = password.Append("5");
            }
            if (date > new DateTime(2050,1,1) && date < new DateTime(2099,12,31))
            {
                password = password.Append("6");
            }
            if (date < new DateTime(1899,12,31) || date > new DateTime(2100,1,1))
            {
                password = password.Append(rnd.Next(7,9));
            }
            int year = date.Year - date.SubString(0, 2);
            Console.WriteLine(password);

        }

        private static void ex17()
        {
            DateTime date = new DateTime(2023, 11, 1);
            int w = System.DateTime.DaysInMonth(date.Year, date.Month);
            while (date < new DateTime(date.Year, date.Month, w))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(date.DayOfWeek);
                    Console.WriteLine(date);
                }
                date = date.AddDays(1);
            }
        }

        private static void ex16()
        {
            DateTime date = new DateTime(2023, 11, 1);
            int w = System.DateTime.DaysInMonth(date.Year, date.Month);
            while (date < new DateTime(date.Year, date.Month, w))
            {
                Console.WriteLine(date);
                date = date.AddDays(1);
            }
        }

        private static void ex14()
        {
            DateTime date = new DateTime(2023, 11, 1);
            DateTime onedate = new DateTime(2021, 5, 23);
            DateTime twodate = new DateTime(2024, 1, 25);
            if (onedate < date && date < twodate)
            {
                Console.WriteLine("Дата находится в заданном диапазоне");
            }
            else
            {
                Console.WriteLine("Дата выходит за диапазон");
            }
        }

        private static void ex15()
        {
            DateTime date = DateTime.Now;
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                date = date.AddDays(1);
                Console.WriteLine(date);
                Console.WriteLine(date.DayOfWeek);
            }
        }

        private static void ex13()
        {
            DateTime date = DateTime.Now;
            DateTime seconddata = new DateTime(2023, 10, 10);
            Console.WriteLine(date.Day - seconddata.Day);
        }

        private static void ex12()
        {
            int day = DateTime.Now.DayOfYear;
            if (day == 1)
            {
                Console.WriteLine("Дата является началом года");
            }
            else
            {
                Console.WriteLine("Дата не является началом года");
            }
        }

        private static void ex11()
        {
            DateTime date = DateTime.Now;
            int days = DateTime.DaysInMonth(2023, 11);
            if (date.Day == days)
            {
                Console.WriteLine("Сегодня последний день месяца");
            }
            else
            {
                Console.WriteLine("Сегодня не последний день месяца");
            }
        }

        private static void ex10()
        {
            int days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine(days);
            if (days == 29)
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }
        }

        private static void ex9()
        {
            int days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine(days);
        }

        private static void ex8()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Начальная дата - " + date);
            Console.WriteLine("Следующая дата - " + DateTime.Today.AddDays(1));
            Console.WriteLine("Предыдущая дата - " + DateTime.Today.AddDays(-1));
        }

        private static void ex7()
        {
            DateTime date = new DateTime(2023, 11, 1, 12, 53, 30);
            string[] dateformats = date.GetDateTimeFormats();
            foreach (string format in dateformats)
            {
                Console.WriteLine(format);
            }
        }

        private static void ex6()
        {
            DateTime date = DateTime.Now;
            DateTime dni = DateTime.Today.AddDays(35);
            TimeSpan hours = new TimeSpan(1, 12, 45);
            DateTime years = DateTime.Today.AddYears(2);
            DateTime months = DateTime.Today.AddMonths(2);
            Console.WriteLine(date);
            Console.WriteLine(dni);
            Console.WriteLine(hours);
            Console.WriteLine(years);
            Console.WriteLine(months);
        }

        private static void ex5()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfYear);
        }

        private static void ex4()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek);
        }

        private static void ex3()
        {
            var dat = new DateTime(2023, 11, 1);
            Console.WriteLine($"Day: {dat.Day}");
            Console.WriteLine($"Month: {dat.Month}");
            Console.WriteLine($"Year: {dat.Year}");
        }

        private static void ex2()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine(data);
        }

        private static void ex1and11and12()
        {
            string str = Console.ReadLine();
            var data = new DateTime(2023,11,1);
            bool p = DateTime.TryParse(str, out data);
            if (p == true)
            {
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Вы ввели не дату");
            }
        }
    }
}
