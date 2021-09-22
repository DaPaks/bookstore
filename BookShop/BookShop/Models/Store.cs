using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Store
    {
        List<NewsPaper> newsPapers = new List<NewsPaper>();
        List<Book> books = new List<Book>();
        public Store()
        {
            // Tilføj et par aviser til butikken
            
          
            NewsPaper politikken = new NewsPaper();
            politikken.Date = DateTime.Today;
            politikken.Id = 1;
            politikken.Pages = 34;
            politikken.Price = 30.50m;
            politikken.Publisher = "Politikken";
            politikken.Title = "Politikken";

            NewsPaper bt = new NewsPaper
            {
                Id = 2,
                Title = "BT",
                Date = DateTime.Today,
                Publisher = "BT",
                Pages = 28,
                Price = 40.50m
            };

            newsPapers.Add(politikken);
            newsPapers.Add(bt);

            Console.WriteLine($"Min boghandel indeholder {newsPapers.Count} aviser.");

            foreach (var item in newsPapers)
            {
                Console.WriteLine($"Navn: {item.Title}, Pris: {item.Price} kr.");
            }

            // Tilføj et par bøger til butikken

            Book hp = new Book();
            hp.Id = 1;
            hp.Price = 150.50m;
            hp.Publisher = "Bloomsbury";
            hp.Title = "Harry Potter";
            hp.Author = "J. K. Rowling";

            Book lotr = new Book
            {
                Id = 1,
                Price = 150.50m,
                Publisher = "Allen & Unwin",
                Title = "Lord of the Rings",
                Author = "J. R. R. Tolkien"
            };

            books.Add(hp);
            books.Add(lotr);

            Console.WriteLine($"Min boghandel indeholder {books.Count} bøger.");

            foreach (var item in books)
            {
                Console.WriteLine($"Navn: {item.Title}, Pris: {item.Price} kr.");
            }
        }

        public void search()
        {
            Console.WriteLine("Hvad vil du søge efter?");
            string searchText = Console.ReadLine();

            foreach (var item in newsPapers)
            {
                if(item.Title.ToLower() == searchText.ToLower())
                {
                    Console.WriteLine($"Avis fundet: {item.Title}");
                }
            }
            foreach (var item in books)
            {
                if (item.Title.ToLower() == searchText.ToLower())
                {
                    Console.WriteLine($"Bog fundet: {item.Title}");
                }
            }

            Console.ReadLine();
        }
    }
}
