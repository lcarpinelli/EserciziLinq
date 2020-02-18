﻿using System;
using System.Collections.Generic;
using System.Linq;
using EserciziLinq;
namespace EserciziLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apple> apples = new List<Apple>
                {
                new Apple { Color = "Red", Weight = 180, Origin ="Italy"},
                new Apple { Color = "Green", Weight = 195, Origin ="France"},
                new Apple { Color = "Red", Weight = 190, Origin ="Italy"},
                new Apple { Color = "Green", Weight = 185, Origin ="Uk"},
                new Apple { Color = "Red", Weight = 200, Origin ="Usa"},
                new Apple { Color = "Green", Weight = 170, Origin ="Germany"},
                new Apple { Color = "Red", Weight = 168, Origin ="Usa"},
                new Apple { Color = "Green", Weight = 193, Origin ="Italy"},
                new Apple { Color = "Red", Weight = 176, Origin ="France"},
                new Apple { Color = "Green", Weight = 210, Origin ="Irland"},
                new Apple { Color = "Red", Weight = 169, Origin ="Irland"},
                new Apple { Color = "Green", Weight = 180, Origin ="Germany"},
                new Apple { Color = "Red", Weight = 185, Origin ="Uk"},
                new Apple { Color = "Green", Weight = 183, Origin ="France"},
                new Apple { Color = "Red", Weight = 195, Origin ="Italy"},
                new Apple { Color = "Green", Weight = 213, Origin ="Irland"},
                };

            //Esercizio 1 Qual è il peso minimo delle mele?
            int minimumWeight = apples.Select(apple => apple.Weight).Min();
            string colorMinimumWeight = apples.Where(apple => apple.Weight == minimumWeight).Select(apple => apple.Color).First();
            string originMinimumWeight = apples.Where(apple => apple.Weight == minimumWeight).Select(apple => apple.Origin).First();
            Console.WriteLine($"La mela che pesa di meno pesa {minimumWeight} Gr ed è di colore {colorMinimumWeight} e proviene da {originMinimumWeight}");

            //Esercizio 2 Di che colore è la mela che pesa 190 grammi?
            string color = apples.Where(apple => apple.Weight == 190).Select(apple => apple.Color).First();
            Console.WriteLine($"La mela è di colore {color}");

            //Esercizio 3 Quante sono le mele rosse?
            int redAppleCount = apples.Where(apple=>apple.Color=="Red").Count();
            Console.WriteLine($"Le mele Rosse sono {redAppleCount}");

            //Esercizio 4 Qual è il peso totale delle mele verdi?
            int totalWeight = apples.Where(apple => apple.Color == "Green").Select(apple => apple.Weight).Sum();
            Console.WriteLine($"Le mele Verdi pesano {totalWeight} Gr");

            //Esercizio 5 Qual è il peso medio delle mele?
            double averageWeight = apples.Select(apple => apple.Weight).Average();
            Console.WriteLine($"La media del peso delle mele è {averageWeight} Gr");

            //Esercizio 6 Da dove viene la mela che pesa di più?
            int maximumWeight = apples.Select(apple => apple.Weight).Max();
            string originMaxWeight = apples.Where(apple => apple.Weight == maximumWeight).Select(apple => apple.Origin).First();
            Console.WriteLine($"La mela che pesa di più pesa {maximumWeight} e proviene da {originMaxWeight}");

            //Esercizio 7 Qual'è la media del peso di mele? 
            double averageWeightItaly = apples.Where(apple => apple.Origin == "Italy").Select(apple => apple.Weight).Average();
            double averageWeightGermany = apples.Where(apple => apple.Origin == "Germany").Select(apple => apple.Weight).Average();
            double averageWeightUk = apples.Where(apple => apple.Origin == "Uk").Select(apple => apple.Weight).Average();
            double averageWeightUsa = apples.Where(apple => apple.Origin == "Usa").Select(apple => apple.Weight).Average();
            double averageWeightFrance = apples.Where(apple => apple.Origin == "France").Select(apple => apple.Weight).Average();
            double averageWeightIrland = apples.Where(apple => apple.Origin == "Irland").Select(apple => apple.Weight).Average();
            
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightItaly)} Gr per Italy");
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightFrance)} Gr per France");
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightGermany)} Gr per Germany");
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightIrland)} Gr per Irland");
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightUk)} Gr per Uk");
            Console.WriteLine($"La media del peso delle mele è {String.Format("{0:0.00}", averageWeightUsa)} Gr per Usa");
        }
    }
}
