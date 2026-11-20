
#region Question1
//Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
//the second price (index 1).

//Double[] prices = new Double[] { 25.5, 40.0, 33.75 };
//Console.WriteLine(prices[1]); 
#endregion

#region Question2
//Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
//shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.

//int[,] shelfCopies = new int[2, 2] { { 3, 5 }, { 1, 4 } };
//Console.WriteLine(shelfCopies[1, 0]);  
#endregion

#region Question3
//Write a method called PrintWelcomeMessage that takes no parameters and prints
//"Welcome to the Library!". Call it from Main

//void PrintWelcomeMessage()
//{
//    Console.WriteLine("Welcome to the Library!");
//}


//PrintWelcomeMessage(); 
#endregion

#region Question4
//Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
//"Clean Code".

//void PrintBookTitle(string title)
//{
//    Console.WriteLine("Book title: " + title);
//}

//PrintBookTitle("Clean Code"); 
#endregion

#region Question5
//Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
//int pages = 400; and print pages afterward. What do you expect to see, and why?

//void AddBonusPages(int pages)
//{
//    pages += 50;
//}
//int pages = 400;
//AddBonusPages(pages);
//Console.WriteLine(pages);

//pages will still be 400 because the method AddBonusPages takes a copy of the variable pages, and any changes made to that copy do not affect the original variable. to make changes to the original variable, we would need to pass it by reference using the ref keyword. 
#endregion

#region Question6
//Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
//with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
//see, and why?

//void ApplyDiscount(double[] prices)
//{
//    prices[0] -= 5;
//}
//double[] prices = { 25.5, 40.0 };
//ApplyDiscount(prices);
//Console.WriteLine(prices[0]);

//this time , prices[0] will be 20.5 because arrays are reference types in C#. When we pass the array to the method, we are passing a reference to the original array, so any changes made to the array inside the method will affect the original array. 
#endregion

#region Question7
//Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
//Call it and print pages afterward. How is the result different from question 5?

//void AddBonusPages(ref int pages)
//{
//    pages += 50;
//}
//int pages = 400;
//AddBonusPages(ref pages);
//Console.WriteLine(pages);

//The result is different from question 5 because we are now passing the variable pages by reference using the ref keyword. This means that any changes made to the parameter inside the method will affect the original variable, so pages will be updated to 450.


#endregion

#region Question8
//Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
//new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
//afterward.

//void ReplaceArray(ref double[] prices)
//{
//    prices = new double[] { 10.0, 12.5, 15.0 };
//}
//double[] prices = { 25.5, 40.0, 33.75,4.5 };
//ReplaceArray(ref prices);
//Console.WriteLine(prices.Length); 
#endregion

#region Question9
//Write a method bool TryGetPrice(string title, out double price) that returns true and sets
//price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
//and print the price if found

//bool TryGetPrice(string title, out double price)
//{
//    if (title == "Clean Code")
//    {
//        price = 25.5;
//        return true;
//    }
//    else
//    {
//        price = 0.0;
//        return false;
//    }
//}

//double price=5.0;
//string title = "Clean Code";
//TryGetPrice(title, out price);
//Console.WriteLine(price); 
#endregion

#region Question10,11

//Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
//it once with only a title, and once passing both a title and pages

//void PrintBookInfo(string title, int pages = 300)
//{
//    Console.WriteLine($"Title: {title}, Pages: {pages}");
//}

//PrintBookInfo("Atomic Habits");
//PrintBookInfo("Pride and Prejudice", 352);
//PrintBookInfo(pages: 400, title: "The Great Gatsby");
#endregion

#region Question12

//Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
//Call it with three book titles.

//void PrintAllTitles(params string[] titles)
//{
//    foreach (string title in titles)
//    {
//        Console.WriteLine(title);
//    }
//}
//PrintAllTitles("Clean Code", "Atomic Habits", "Pride and Prejudice"); 
#endregion