using System;
using BookShop.Models;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til min butik");
            Store store = new Store();
            store.search();
        }
    }
}
