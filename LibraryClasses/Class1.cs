using System;
using System.Collections;
using System.Collections.Generic;
using  System.Collections.Generic;
    

namespace LibraryClasses
{
    public interface ILoanable
    {
        int LoanPeriod { get; set; }
        List<string> Borrower { get; set; }

        void Borrow(int loanPeriod, string borrower);
        void Return(string borrower);
    }

    public interface IPrintable
    {
        void Print();
    }

    public interface IItem:ILoanable,IPrintable, IEquatable<IItem>
    {
        
         int Quantity { get; set; }
        int Loanable { set; get; } 
    }
    public class Book : IItem
    {
        public int LoanPeriod { get; set; }
        public List<string> Borrower { set; get; } = new List<string>() ; 
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; } = 24;

        public int Loanable { set; get; } = 21;

        public void Borrow(int loanPeriod , string borrower)
        {
            if (Quantity != 0 && loanPeriod <= Loanable)
            {
                LoanPeriod = loanPeriod;
                Borrower.Add(borrower);
                Amount = LoanPeriod * Price;
                Console.WriteLine($"Book-{Title} has been borrowed by {borrower}");
                Quantity--;
            }
            else if(loanPeriod >Loanable)
            {
                Console.WriteLine($"Book is Loanable for only {Loanable} days");
            }
            else
            {
                Console.WriteLine($"Book-{Title} is not available ");
            }
           

        }

        public void Print()
        {
            Console.WriteLine("Book Details....");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Autor : {Author}");
            Console.WriteLine($"Cost Per Day : {Price}");
        }

        public void Return(string borrower)
        {
            Quantity++;
            Console.WriteLine($"Thank you , here's the amount to be paid {Amount}");
            Amount = 0;
            Borrower.Remove(borrower);

        }

        bool IEquatable<IItem>.Equals(IItem? other)
        {
            if (other == null) return false;
            Book book = (Book)other;
            return this.Title == book.Title && this.Author == book.Author;
        }
    }

    public class DVD : IItem
    {
        public int LoanPeriod { get ; set ; }
        public List<string> Borrower { get; set; } = new List<string>();
        public string Director { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public  int Quantity { get; set; } = 13;

        public int Loanable { set; get; } = 7;

        public void Borrow(int loanPeriod, string borrower)
        {
            if (Quantity != 0 && loanPeriod <= Loanable)
            {
                LoanPeriod = loanPeriod;
                Borrower.Add(borrower);
                Amount = LoanPeriod * Price;
                Console.WriteLine($"DVD-{Title} has been borrowed by {borrower}");
                Quantity--;
            }
            else if (loanPeriod > Loanable)
            {
                Console.WriteLine($"DVD is Loanable for only {Loanable} days");
            }
            else
            {
                Console.WriteLine($"DVD-{Title} is not available ");
            }
        }

        public void Print()
        {
            Console.WriteLine("DVD Details....");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Director : {Director}");
            Console.WriteLine($"Cost Per Day : {Price}");
        }

        public void Return(string borrower)
        {
            Quantity++;
            Console.WriteLine($"Thank you , here's the amount to be paid {Amount}");
            Amount = 0;
            Borrower.Remove(borrower);
        }

        bool IEquatable<IItem>.Equals(IItem? other)
        {
            if (other == null) return false;
            DVD dvd = (DVD)other;
            return this.Title == dvd.Title && this.Director == dvd.Director;
        }
    }

    public class CD : IItem
    {
        public int LoanPeriod { get ; set ; }
        public List<string> Borrower { get; set; } = new List<string>();
        public string Artist { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public  int Quantity { get; set; } = 10 ;

        public int Loanable { set; get; } = 14;

        public void Borrow(int loanPeriod, string borrower)
        {
            if (Quantity != 0 && loanPeriod <= Loanable)
            {
                LoanPeriod = loanPeriod;
                Borrower.Add(borrower);
                Amount = LoanPeriod * Price;
                Console.WriteLine($"CD-{Title} has been borrowed by {borrower}");
                Quantity--;
            }
            else if (loanPeriod > Loanable)
            {
                Console.WriteLine($"CD is Loanable for only {Loanable} days");
            }
            else
            {
                Console.WriteLine($"CD-{Title} is not available ");
            }
        }

        public void Print()
        {
            Console.WriteLine("DVD Details....");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Artist : {Artist}");
            Console.WriteLine($"Cost Per Day : {Price}");
        }

        public void Return(string borrower)
        {
            Quantity++;
            Console.WriteLine($"Thank you , here's the amount to be paid {Amount}");
            Amount = 0;
            Borrower.Remove(borrower);
        }

        bool IEquatable<IItem>.Equals(IItem? other)
        {
            if (other == null) return false;
            CD cd = (CD)other;
            return this.Title == cd.Title && this.Artist == cd.Artist;
        }
    }


    public class Library
        { 
        List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
           
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
         
        public void PrintLibrary()
        {
            Console.WriteLine(items.Count);
           foreach(var item in items)
            {
                //Console.WriteLine("Hii");
                item.Print();
            
                Console.WriteLine("1.Borrow \n 2.Return \n 3.Next \n 4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {
                    Console.Write("Enter you Name: ");
                    string borrower= Console.ReadLine();
                    Console.Write("Loan Period: ");
                    int loanPeriod = Convert.ToInt32(Console.ReadLine());
                    item.Borrow(loanPeriod, borrower);

                }
                else if(choice == 2)
                {
                    Console.Write("Enter you Name: ");
                    string borrower = Console.ReadLine();
                    item.Return(borrower);
                }
                else if(choice == 4)
                {
                    Console.WriteLine("Thank you!! Do visit again!");
                }
            }
        }

       
    }
}
