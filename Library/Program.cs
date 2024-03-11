using LibraryClasses;

namespace LibraryModule
{

    

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            Library library = new Library();
            do
            {
                Console.WriteLine("----Library---");
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("1.View Library");
                Console.WriteLine("2.Add new item");
                Console.WriteLine("3.Remove item");
                Console.WriteLine("4.Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                
               
                switch(choice)
                {
                    case 1:
                        {
                            library.PrintLibrary();
                            break;
                        }
                       
                
                    case 2:
                        {
                            int ch = -1;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("Choose item to add..");
                                Console.WriteLine("1.Book\n2.DVD\n3.CD\n4.Exit");

                                ch = Convert.ToInt32(Console.ReadLine());
                                switch(ch)
                                {
                                    case 1:
                                        {
                                            Book book = new Book();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            book.Title = Console.ReadLine();
                                            Console.Write("Author: ");
                                            book.Author = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            book.Price = Convert.ToDouble(Console.ReadLine());
                                            IItem book1 = (IItem)book;
                                            library.AddItem(book1);

                                            break;
                                        }
                                    case 2:
                                        {
                                            DVD dvd = new DVD();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            dvd.Title = Console.ReadLine();
                                            Console.Write("Director: ");
                                            dvd.Director = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            dvd.Price = Convert.ToDouble(Console.ReadLine());
                                            library.AddItem(dvd);
                                            break;
                                        }
                                    case 3:
                                        {
                                            CD cd = new CD();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            cd.Title = Console.ReadLine();
                                            Console.Write("Artist: ");
                                            cd.Artist = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            cd.Price = Convert.ToDouble(Console.ReadLine());
                                            library.AddItem(cd);
                                            break;
                                           
                                        }
                                

                                }

                            } while (ch != 4);
                            break;
                        }
                    case 3:
                        {
                            int ch = -1;
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("Choose item to remove..");
                                Console.WriteLine("1.Book\n2.DVD\n3.CD\n4.Exit");

                                ch = Convert.ToInt32(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        {
                                            Book book = new Book();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            book.Title = Console.ReadLine();
                                            Console.Write("Author: ");
                                            book.Author = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            book.Price = Convert.ToDouble(Console.ReadLine());
                                            library.RemoveItem(book);
                                            break;
                                        }
                                    case 2:
                                        {
                                            DVD dvd = new DVD();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            dvd.Title = Console.ReadLine();
                                            Console.Write("Director: ");
                                            dvd.Director = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            dvd.Price = Convert.ToDouble(Console.ReadLine());
                                            library.RemoveItem(dvd);
                                            break;
                                        }
                                    case 3:
                                        {
                                            CD cd = new CD();
                                            Console.WriteLine("Enter the details");
                                            Console.Write("Title: ");
                                            cd.Title = Console.ReadLine();
                                            Console.Write("Artist: ");
                                            cd.Artist = Console.ReadLine();
                                            Console.WriteLine("Cost Per Day: ");
                                            cd.Price = Convert.ToDouble(Console.ReadLine());
                                            library.RemoveItem(cd);
                                            break;

                                        }


                                }

                            } while (ch != 4);
                            break;
                        }
                       
                }
            } while (choice != 4);
        }
    }
}
