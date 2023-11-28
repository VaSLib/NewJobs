using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewJobs
{
    internal class Poster
    {
        public static List<Cinema> cinema = new List<Cinema>()
        {
            new Cinema()
            {
                Title="Наполеон",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 200

            },
            new Cinema()
            {
                Title="Напол",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 300
            },
            new Cinema()
            {
                Title="леон",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 400
            },
            new Cinema()
            {
                Title="поле",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",
                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 500
            }

        };
        public static List<Cinema> cinemaSoon = new List<Cinema>()
        {
            new Cinema()
            {
                Title="Наполеон 2",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 200

            },
            new Cinema()
            {
                Title="Наполеон 3",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 200
            },
            new Cinema()
            {
                Title="Наполеон 4",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",

                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 200
            },
            new Cinema()
            {
                Title="Наполеон 5",
                Description="История тяжёлого пути Бонапарта к власти через призму " +
                "его\nизменчивых отношений с единственной настоящей любовью, Жозефиной.",
                Time=new DateTime(2015, 7, 20, 18, 30, 25),
                Price = 200
            }

        };
    }
}
