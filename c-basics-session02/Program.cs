using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;

class book
{
    string title;
    int pages;

}

class Program
{
    static void Main()
    {
        #region Question1
        //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
        //variable of type object.Print it.

        //book b1 = new book();
        //object obj = b1;
        //Console.WriteLine(obj); 
        #endregion


        #region Question2
        //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
        //itself), GetHashCode(), and GetType() on book.
        //book book = new book();
        //Console.WriteLine(book.ToString());
        //Console.WriteLine(book.GetHashCode());
        //Console.WriteLine(book.Equals(book));
        //Console.WriteLine(book.GetType()); 
        #endregion

        #region Question3
        //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
        //int pages = "464"; is a compile time error because we are trying to assign a string value to an int variable
        //so the correct way to assign the value would be:
        //int pages = 464;

        #endregion

        #region Question4
        //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
        //zero", and then prints "Done" in a finally block.

        //int num01 = 10;
        //int num02 = 0;
        //try
        //{
        //    int result = num01 / num02;

        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Cannot divide by zero.");
        //}
        //finally
        //{
        //    Console.WriteLine("Done");
        //} 
        #endregion

        #region Question5
        //Declare an int pages = 300; then store it in a double variable without using a cast.
        //int pages = 300;
        //double PagesDouble = pages;
        //Console.WriteLine(PagesDouble); 
        #endregion

        #region Question6
        //Declare a double price = 49.99; then convert it into an int using a cast.

        //double price = 49.99;
        //int priceInt = (int)price;
        //Console.WriteLine(priceInt); 
        #endregion

        #region Question7
        // Given string pagesText = "464";, convert it into an int using the Convert class.
        //string pagesText = "464";
        //int pages = Convert.ToInt32(pagesText);
        //Console.WriteLine(pages); 
        #endregion

        #region Question8
        //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
        //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
                //string yearText = "2023";
                //int yearInt = int.Parse(yearText);
                //Console.WriteLine(yearInt);
                //string badText = "abc";
                //int badInt = 0;
                //bool isParsed = int.TryParse(badText, out badInt);
                //Console.WriteLine(badInt);
                //Console.WriteLine("Invalid number"); 
        #endregion
    }
}