
using KinoTheaterProject.Models;
using KinoTheaterProject.Services;

namespace KinoTheaterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var theatre = new Theatre();
            var hallManager = new HallManager();
            var filmManager = new FilmManager();
            var ticketManager = new TIcketManager();
            var seansManager = new SeansManager();
            string command = string.Empty;

            theatre.Name = "GabalaCityCinema";
            Console.WriteLine(theatre.Name);


            var seans1 = new Seans
            {
                Id = 1,
                DateTime = "15:00",
                Film = "Upgrade",
                Hall = "Zal 1"
            };

            var seans2 = new Seans
            {
                Id = 2,
                DateTime = "18:00",
                Film = "Seven Pounds",
                Hall = "Zal 2"
            };

            var seans3 = new Seans
            {
                Id = 3,
                DateTime = "20:30",
                Film = "1917",
                Hall = "Zal 3"
            };

            var seans4 = new Seans
            {
                Id = 4,
                DateTime = "22:30",
                Film = "The Pursuit of Happyness",
                Hall = "Zal 4"
            };
            seansManager.Add(seans1);
            seansManager.Add(seans2);
            seansManager.Add(seans3);
            seansManager.Add(seans4);

            var hall1 = new Hall
            {
                Id = 1,
                Name = "Zal 3",
                hallraw = 10,
                hallcolumn = 10
            };
            var hall2 = new Hall
            {
                Id = 2,
                Name = "Zal 2",
                hallraw = 10,
                hallcolumn = 10
            };
            var hall3 = new Hall
            {
                Id = 3,
                Name = "Zal 3",
                hallraw = 15,
                hallcolumn = 10
            };
            hallManager.Add(hall1);
            hallManager.Add(hall2);
            hallManager.Add(hall3);

            var film1 = new Film()
            {
                Id = 1,
                Name = "Upgrade",
                Director = "Leigh Whannell",
                Date = "June 14, 2018 (Australia)",
                Genre = "Sci-fi/Action"
            };
            var film2 = new Film()
            {
                Id = 2,
                Name = "Seven Pounds",
                Director = "Gabriele Muccino",
                Date = "December 19, 2008 (USA)",
                Genre = "Drama/Romance"
            };

            var film3 = new Film()
            {
                Id = 3,
                Name = "1917",
                Director = " Sam Mendes",
                Date = " December 25, 2019 (USA)",
                Genre = " War/Drama"
            };
            var film4 = new Film()
            {
                Id = 4,
                Name = "The Pursuit of Happyness",
                Director = "Gabriele Muccino",
                Date = "December 15, 2006 (USA)",
                Genre = "Drama"
            };
            filmManager.Add(film1);
            filmManager.Add(film2);
            filmManager.Add(film3);
            filmManager.Add(film4);

            do
            {
                Console.Write("Enter the Command: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("print hall"))
                {
                    hallManager.Print();
                }
                else if (command.ToLower().Equals("update hall"))
                {
                    Console.Write("Enter the ID: ");
                    var id = Convert.ToInt32(Console.ReadLine());
                    var existHall = hallManager.Get(id);

                    var hall4 = new Hall
                    {
                        Id = 4,
                        Name = "Zal 4",
                        hallraw = 20,
                        hallcolumn = 20
                    };
                    hallManager.Update(id, hall4);
                }
                else if (command.ToLower().Equals("get hall"))
                {
                    Console.Write("Enter the ID: ");
                    var id = int.Parse(Console.ReadLine());
                    hallManager.Get(id);
                }
                else if(command.ToLower().Equals("show seans"))
                {
                    seansManager.Print();
                }
                else if (command.ToLower().Equals("show films"))
                {
                    filmManager.Print();
                }
                else if(command.ToLower().Equals("delete films"))
                {
                    Console.Write("Enter the ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());  
                    filmManager.Delete(id);
                }
                else if(command.ToLower().Equals("update film"))
                {
                    int id = int.Parse(Console.ReadLine());

                    var film5 = new Film()
                    {
                        Id = 5,
                        Name = "Ocean's Eleven",
                        Director = " Steven Soderbergh",
                        Date = "December 7, 2001 (USA)",
                        Genre = "Crime/Comedy"
                    };
                    filmManager.Update(id, film5);
                }
                else if (command.ToLower().Equals("get film"))
                {
                    Console.Write("Id daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    filmManager.Get(id);
                }
                else if (command.ToLower().Equals("add ticket"))
                {
                    var ticket = new Tickets();
                    seansManager.Print();
                    int id = Convert.ToInt32(Console.ReadLine());
                    seansManager.Get(id);

                    string[,] area = new string[15,10];
                    ticket.Id= 1;
                    ticket.Price = 13;

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            area[i, j] = "empty";
                            Console.Write($"{area[i, j]}"+ " ");
                        }
                    }
                    Console.WriteLine();

                    Console.Write("Oturmaq istediyiniz sira: ");
                    int row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Oturmaq istediyiniz yer: ");
                    int column = int.Parse(Console.ReadLine());
                    area[row - 1, column - 1] = "full";

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write($"{area[i, j]}" + " ");
                        }
                    }
                    Console.WriteLine();

                    ticketManager.Add(ticket);
                    ticketManager.Get(1);
                    Console.WriteLine("Bilet aldiniz");
                }


            } while (!command.ToLower().Equals("quit"));

        }
    }
}