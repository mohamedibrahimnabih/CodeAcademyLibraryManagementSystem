using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Book> books = [];
            ApplicationDbContext _db = new();

            do
            {

                Console.WriteLine("\n1. Add New Book");
                Console.WriteLine("2. Add New Book");

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
                    case 2:
                        {
                            Console.WriteLine("Enter Id");
                            string id = Console.ReadLine();

                            Console.WriteLine("Enter First Name");
                            string firstName = Console.ReadLine();

                            Console.WriteLine("Enter Last Name");
                            string lastName = Console.ReadLine();

                            Console.WriteLine("Enter Phone");
                            string phone = Console.ReadLine();

                            Console.WriteLine("Enter Email");
                            string email = Console.ReadLine();

                            Console.WriteLine("Enter Address");
                            string address = Console.ReadLine();

                            User user = new()
                            {
                                Id = id,
                                FirstName = firstName,
                                LastName = lastName,
                                PhoneNumber = phone,
                                Email = email,
                                Address = address
                            };

                            _db.Users.Add(user);
                            _db.SaveChanges();

                            Console.WriteLine("Add User Successfully");
                        }
                        break;
                }

            } while (true);
        }
    }
}
