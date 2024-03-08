
using System;
using System.IO;
/*ILoanable: defines the properties and methods that an item that can be borrowed should have.
 * This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.

IPrintable: defines the method Print, which should print out information about the item.*/
interface ILoanable
{
    int LoanPeriod { set; get; }

    string Borrower { set; get; }

    void Borrow(string borrower,int loanPeriod);
    double Return();

}

interface IPrintable
{
    void Print();
}


/*Next, create classes that implement the ILoanable and IPrintable interfaces for the following types of items:

Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.

Each class should implement the ILoanable and IPrintable interfaces in a way that is appropriate for that item.*/

class Book:ILoanable,IPrintable
{
    
    int _loanPeriod;
    string _borrower;
    

    public string Author { set; get; }
    public string Title { set; get; }
    public string ISBN { set; get; }
    public double Amount { set; get; }
    public double CostPerDay { set; get; }
    public int LoanPeriod
    {
        set
        {
            this._loanPeriod = value;
        }
        get
        {
            return this._loanPeriod;
        }
    }
    public string Borrower
    {
        set
        {
            this._borrower = value;
        }
        get
        {
            return this._borrower;
        }
    }

    public void Borrow(string borrower, int loanPeriod)
    {
        if(loanPeriod > this.LoanPeriod)
        {
            Console.WriteLine("Cannot borrow book for more than " + this.LoanPeriod + " days!");
        }
        else
        {
            this.Amount = loanPeriod * this.CostPerDay;
            this.Borrower = borrower;
            Console.WriteLine("Book borrowed , amount to be paid: " + this.Amount);
        }
    }

    public double Return()
    {
        return this.Amount;
    }

    public void Print()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: "+this.Title);
        Console.WriteLine("Author: "+ this.Author);
        Console.WriteLine("Loan Period: "+ this.LoanPeriod);
        Console.WriteLine("Cost Per Day: "+ this.CostPerDay);
    }
}

/*DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.*/
class DVD : ILoanable, IPrintable
{

    int _loanPeriod;
    string _borrower;


    public string Director { set; get; }
    public string Title { set; get; }
    public int LengthInMinutes { set; get; }
    public double Amount { set; get; }
    public double CostPerDay { set; get; }
    public int LoanPeriod
    {
        set
        {
            this._loanPeriod = value;
        }
        get
        {
            return this._loanPeriod;
        }
    }
    public string Borrower
    {
        set
        {
            this._borrower = value;
        }
        get
        {
            return this._borrower;
        }
    }

    public void Borrow(string borrower, int loanPeriod)
    {
        if (loanPeriod > this.LoanPeriod)
        {
            Console.WriteLine("Cannot borrow DVD for more than " + this.LoanPeriod + " days!");
        }
        else
        {
            this.Amount = loanPeriod * this.CostPerDay;
            this.Borrower = borrower;
            Console.WriteLine("DVD borrowed , amount to be paid: " + this.Amount);
        }
    }

    public double Return()
    {
        return this.Amount;
    }

    public void Print()
    {
        Console.WriteLine("DVD Details:");
        Console.WriteLine("Title: " + this.Title);
        Console.WriteLine("Director: " + this.Director);
        Console.WriteLine("Loan Period: " + this.LoanPeriod);
        Console.WriteLine("Cost Per Day: " + this.CostPerDay);
    }
}

//CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.
class CD : ILoanable, IPrintable
{

    int _loanPeriod;
    string _borrower;


    public string Artist { set; get; }
    public string Title { set; get; }
    public int NumberofTracks { set; get; }
    public double Amount { set; get; }
    public double CostPerDay { set; get; }
    public int LoanPeriod
    {
        set
        {
            this._loanPeriod = value;
        }
        get
        {
            return this._loanPeriod;
        }
    }
    public string Borrower
    {
        set
        {
            this._borrower = value;
        }
        get
        {
            return this._borrower;
        }
    }

    public void Borrow(string borrower,int loanPeriod)
    {
        if (loanPeriod > this.LoanPeriod)
        {
            Console.WriteLine("Cannot borrow CD for more than " + this.LoanPeriod + " days!");
        }
        else
        {
            this.Borrower = borrower;
            this.Amount = loanPeriod * this.CostPerDay;
            Console.WriteLine("CD borrowed , amount to be paid: " + this.Amount);
        }
    }

    public double Return()
    {
        return this.Amount;
    }

    public void Print()
    {
        Console.WriteLine("CD Details:");
        Console.WriteLine("Title: " + this.Title);
        Console.WriteLine("Artist: " + this.Artist);
        Console.WriteLine("Loan Period: " + this.LoanPeriod);
        Console.WriteLine("Cost Per Day: " + this.CostPerDay);
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book();
        DVD dvd = new DVD();
        CD cd = new CD();

        book.Title = "Wings of Fire";
        book.Author = "APJ Abdul kalam";
        book.CostPerDay = 12;
        book.LoanPeriod = 21;

        dvd.Title = "Inception";
        dvd.Director = "Cristopher nolan";
        dvd.CostPerDay = 6;
        dvd.LoanPeriod = 7;

        cd.Title = "Iron Man";
        cd.Artist = "Akanksha";
        cd.CostPerDay = 24;
        cd.LoanPeriod = 14;
               
        book.Print();
        dvd.Print();
        cd.Print();

        book.Borrow("Tanuja",15);


    }
}