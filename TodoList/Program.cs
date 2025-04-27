Console.WriteLine("Provide a number.");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
Console.WriteLine(number);


//Console.WriteLine("Hello!");
//Console.WriteLine("[s]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//string userChoice = Console.ReadLine();
//bool isLong = IsLong(userChoice);

//bool IsLong(string input)
//{
//    return input.Length > 10;
//}

//var result = Add(10, 5);
//Console.WriteLine("10 + 5 = " + result);

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("selected option: " + selectedOption);
//}

//int Add(int a, int b)
//{
//    return a + b;
//}

Console.ReadKey(); //preventing window closing

