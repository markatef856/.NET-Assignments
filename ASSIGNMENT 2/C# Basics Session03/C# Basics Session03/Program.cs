using System.Drawing;
using System.Text;

#region Session'sTask

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();

//Console.Write("Enter your age: ");
//int age = int.Parse(Console.ReadLine());

//Console.Write("Enter Grade1: ");
//int grade1 = int.Parse(Console.ReadLine());

//Console.Write("Enter Grade2: ");
//int grade2 = int.Parse(Console.ReadLine());

//Console.Write("Enter Grade3: ");
//int grade3 = int.Parse(Console.ReadLine());

//int total = grade1 + grade2 + grade3;

//int average = total / 3;

//string AgeGroup;

//string GradeGroup;

//if (age < 18)
//{
//    AgeGroup = "Minor";
//}
//else
//{
//    AgeGroup = "Adult";
//}

//if (average >= 50)
//{
//    GradeGroup = "passed";
//}

//else
//{
//    GradeGroup = "failed";
//}

//Console.WriteLine($"\n\n Student Name: {name} \n Age: {age} ({AgeGroup}) \n\n Total: {total} \n Average Grade: {average} \n\n status: {GradeGroup}");


//this program could've handled more situations, like if the user inputs a non-integer value for age or grades, but it's not a requirement for this task, so I didn't implement it.
#endregion


#region Question1
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
//both title and upperTitle to show that title did not change.
//string title = "clean code";
//String upperTitle = title.ToUpper();
//Console.WriteLine(title);
//Console.WriteLine(upperTitle); 
#endregion

#region Question2
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
//to check if they point to the same object in memory.

//string str01 = "clean code";
//string str02 = "clean code";
//Console.WriteLine(string.ReferenceEquals(str01, str02)); its true
#endregion

#region Question3,4
//Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
//object. Print the final result.

//Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
//Print the result

//StringBuilder sb = new StringBuilder();
//sb.Append("Book List");
//sb.Append("- Updated");
//Console.WriteLine(sb.ToString());
//sb.Replace("Book List", "Library");
//Console.WriteLine(sb.ToString());
#endregion

#region Question5,6,7
//Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
//Pages: 464" using the + operator.

//Build the same sentence as above, but using string interpolation ($"...").
//Build the same sentence again, but using string.Format().

//string title = "Clean Code";
//int pages = 464;
//Console.WriteLine("Book: " + title + ", Pages: " + pages);
//Console.WriteLine($"Book: {title}, Pages: {pages}");
//Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages)); 
#endregion

#region Question8
//Given int pages = 464;, write an if statement that prints "long book." if pages is greater than 300, and "short book." otherwise.

//int pages = 464;
//if (pages > 300)
//{
//    Console.WriteLine("long book.");
//}

//else
//{
//    Console.WriteLine(" short book.");
//} 
#endregion

#region Question9
//Given int pages = 464; and bool isAvailable = true;, write an if statement that prints "You can borrow this book" if pages is greater than 300 and isAvailable is true.
//int pages = 464;
//bool isAvailable = true;
//if (pages > 300 && isAvailable == true)
//{
//	Console.WriteLine("You can borrow this book");
//}

#endregion

#region Question10
//Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if title is "Clean Code", "Nice pick!" if title is "Refactoring", and "Never heard of it" for any other value.
//string title = "Refactoring";
//switch (title)
//{
//    case "Clean Code":
//        Console.WriteLine("Great choice!");
//        break;
//    case "Refactoring":
//        Console.WriteLine("Nice pick!");
//        break;
//    default:
//        Console.WriteLine("Never heard of it");
//        break;
//} 
#endregion

#region Question11
//Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).

//int pages = 464;

//string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

//Console.WriteLine(sizeLabel); 
//we still didn't learn the ternary operator, but this is how it works
#endregion

#region Question12
//Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
//to print each book with its position number, like 1.Clean Code

//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//for (int i = 0; i <= 2; i++)
//{
//	Console.WriteLine($"{i + 1}." + books[i]);
//}
#endregion

#region Question13
//Using the same books array, use a while loop to print every book title

//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//int i = 0;
//while (i <= 2)
//{
//    Console.WriteLine(books[i]);
//    i++;
//}  
#endregion

#region Question14
//Write a do-while loop that prints "Checking book..." exactly 3 times.
//int counter = 0;
//do
//{
//    Console.WriteLine("Checking book...");
//    counter++;
//}
//while (counter < 3); 
#endregion

#region Question15
//Using the same books array, use a foreach loop to print every book title.

//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//foreach (string book in books)
//{
//	Console.WriteLine(book);
//} 
#endregion

#region Question16
//Using the same books array, loop through it and print each title, but stop completely (break) once
//you reach "Refactoring".

//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//for (int i = 0; i <= 2; i++)
//{
//    if (books[i] == "Refactoring")
//    {
//        break;
//    }
//    Console.WriteLine($"{i + 1}." + books[i]);
//}
#endregion

#region Question17
//Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
//continue, don't stop the loop).

//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
//for (int i = 0; i <= 2; i++)
//{
//    if (books[i] == "The Pragmatic Programmer")
//    {
//        continue;
//    }
//    Console.WriteLine($"{i + 1}." + books[i]);
//} 
#endregion