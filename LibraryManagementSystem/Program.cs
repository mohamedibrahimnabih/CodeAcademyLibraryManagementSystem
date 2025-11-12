using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                List<Book> books = [];
                ApplicationDbContext _db = new();

                Console.WriteLine("\n1. Add New Book");
                Console.WriteLine("2. Quit");

                Console.WriteLine("Enter Your Selection");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch(selection)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter ISBN");
                            string isbn = Console.ReadLine();

                            Console.WriteLine("Enter Title");
                            string title = Console.ReadLine();

                            Console.WriteLine("Enter Author");
                            string author = Console.ReadLine();

                            Console.WriteLine("Enter About");
                            string about = Console.ReadLine();

                            Console.WriteLine("Enter Price");
                            decimal price = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Enter Quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            Book book = new()
                            {
                                ISBN = isbn,
                                About = about,
                                Price = price,
                                Author = author,
                                Quantity = quantity,
                                Title = title,
                                Rate = 0
                            };

                            _db.Books.Add(book);
                            _db.SaveChanges();

                            Console.WriteLine("Add Book Successfully");
                        }
                        break;
                }

            } while (true);
        }
    }
}
