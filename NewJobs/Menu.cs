using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJobs
{
    internal class Menu
    {
        
        public static int? Balans { get; set ; }
        public static List<Cinema> Ticket = new List<Cinema>();

        public static void Start()
        { 
            MainHelper.GetBalans();
            MainHelper.ShowMenu();


        }

        public static List<MenuOption> options = new List<MenuOption>()
        {
            new MenuOption()
            {
                Title = "Афиша",
                Action = MainHelper.ShowPosters,
            },
            new MenuOption()
            {
                Title = "Скоро",
                Action = MainHelper.ShowPostersSoon,
            },
            new MenuOption()
            {
                Title = "Купленные билеты",
                Action = MainHelper.ShowTickets,
            },

            new MenuOption()
            {
                Title = "Выйти",
                Action = OnExit,
            },
        };
        

        public static void OnExit()
        {
            Environment.Exit(0);
        }

    }
}
