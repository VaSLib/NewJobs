using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJobs
{
    internal class MainHelper
    {
        

        public static void GetBalans()=>Menu.Balans = InputHelper.ReadNumber("Введите свой баланс");

        public static void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            List<MenuOption> options = Menu.options;
            int number = 0;

            do
            {
                PrintFirst("Главная");
                Console.WriteLine("Баланс:"+Menu.Balans);
                Console.WriteLine();

                for (int NumberCinema = 0; NumberCinema < options.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(options[NumberCinema].Title);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + options.Count()) % options.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % options.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[number].Action();

                }

            } while (keyInfo.Key != ConsoleKey.Escape);



        }

        public static void ShowPosters()
        {
            ConsoleKeyInfo keyInfo;
            int number = 0;
            List<Cinema> menuItems = Poster.cinema;
            do
            {

                PrintFirst("Афиша");

                for (int NumberCinema = 0; NumberCinema < menuItems.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    PrintCinema(menuItems,NumberCinema);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + menuItems.Count()) % menuItems.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % menuItems.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                { 
                SetTicket(menuItems, number,Menu.Balans);
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        

        public static void ShowPostersSoon()
        {
            ConsoleKeyInfo keyInfo;
            int number = 0;
            List<Cinema> menuItems = Poster.cinemaSoon;
            do
            {



                PrintFirst("Скоро");

                for (int NumberCinema = 0; NumberCinema < menuItems.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    PrintCinema(menuItems, NumberCinema);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + menuItems.Count()) % menuItems.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % menuItems.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {

                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
        public static void ShowTickets()
        {
            ConsoleKeyInfo keyInfo;
            int number = 0;
            List<Cinema> menuItems = Menu.Ticket;
            do
            {
                

                int NumberCinema = 0;

                PrintFirst("Купленные билеты");

                for (; NumberCinema < menuItems.Count; NumberCinema++)
                {
                    if (NumberCinema == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    PrintCinema(menuItems, NumberCinema);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + menuItems.Count()) % menuItems.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % menuItems.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                }
                Console.Clear();

            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        public static void SetTicket(List<Cinema> menuItems, int cinemaNumber,int? balans)
        {
            if (balans >= menuItems[cinemaNumber].Price)
            {
                
                Menu.Ticket.Add( menuItems[cinemaNumber] );
                Menu.Balans-= menuItems[cinemaNumber].Price;
            }
        }


        public static void PrintCinema (List<Cinema> menuItems, int CinemaNumber)
        {
            Console.WriteLine("\n"+menuItems[CinemaNumber].Title);
            Console.WriteLine("Описание:"+menuItems[CinemaNumber].Description);
            Console.WriteLine("Дата:"+menuItems[CinemaNumber].Time);
            Console.WriteLine("Цена:"+menuItems[CinemaNumber].Price);

        }
        public static void PrintFirst (string? name)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"      {name}      \n");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        

    }
}
