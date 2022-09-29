#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("What is your name?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

//Writing it back to the console
Console.WriteLine("Aaah, welcome " + myString + ", nice to meet you!");
#endregion

#region Data types
Console.WriteLine("Do you want to learn about the simplest data types?");
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/

string answer = Console.ReadLine();

bool LearnAboutDataTypes = false;
if(answer == "yes"){
    LearnAboutDataTypes = true;
}

if(LearnAboutDataTypes == true){
    Console.WriteLine("Then you have come to the right place!");
    Console.WriteLine("The 'bool' type can either be 'true' or 'false', nothing more, nothing less.");
    Console.WriteLine("When you answered 'yes', a bool named 'LearnAboutDataTypes' was set to 'true'");
    Console.WriteLine("And allowed for these messages!");
    Console.WriteLine("...");
    Console.ReadLine();
    
    Console.WriteLine("Now... The next data type we are gonna talk about is the integer, called an 'int'");
    Console.WriteLine("It is used to store whole numbers, like 1,2,3,4 and so on.");
    Console.WriteLine("Try inserting an integer now:");
    string inputFromConsole = Console.ReadLine();
    int number = int.Parse(inputFromConsole);
    
    Console.WriteLine("I have now converted a text string into an integer!");
    number = number + 1;
    //number++;
    //number += 1;
    Console.WriteLine("We can now do math operations on it, and voila, your number + 1 is equal to = " + number);
    Console.WriteLine("...");
    Console.ReadLine();

    Console.WriteLine("Next up we have the Float data type");
    Console.WriteLine("Float is decimal numbers, you can do math on it, just as we did with the integer");
    Console.WriteLine("Remember to use 'f'!");
    float OneThird = 1.0f/3.0f; //Notice the 'f' to indicate this number is a float value
    Console.WriteLine("Like for example 1.0f/3.0f, which gives : " + OneThird);
    Console.WriteLine("where as 1/3 gives = " + 1/3 + ". Because the computer thinks it is working with whole numbers (integers)");
    Console.WriteLine("...");
    Console.ReadLine();

    Console.WriteLine("Lastly, the string data type.");
    Console.WriteLine("Strings are text, and can be found between quotation marks");
    Console.WriteLine("We have used strings to read and write to the console, this line is a string");
    Console.WriteLine("...");
    Console.ReadLine();
}



    Console.WriteLine("Do you wanna learn more?");
    Console.WriteLine("...");
string a = Console.ReadLine();
bool MoreInfo = false;
if (a == "yes"){
    MoreInfo = true;
}

if (MoreInfo == true){
    Console.WriteLine("");
    Console.WriteLine("I am really sorry");
    Console.WriteLine("But I really do not know more myself");
    Console.WriteLine("");
    Console.WriteLine("Maybe if you type GiGeGosnGsGimomiefsGmioefsmfsfGomiesfoimfGmiosemfpsfsG you will learn more");
}

string b = Console.ReadLine();
bool HardWord = false;
if (b == "GiGeGosnGsGimomiefsGmioefsmfsfGomiesfoimfGmiosemfpsfsG"){
    HardWord = true;
}

if (HardWord == true){
    Console.WriteLine("");
    Console.WriteLine("You know how to write that hard word");
    Console.WriteLine("There is not more for you to know in the world");
    Console.WriteLine("YOU ARE FREE KNOW");
    Console.ReadLine();
}

if (HardWord == false){
    Console.WriteLine("");
    Console.WriteLine("HAHAHAHAHA");
    Console.WriteLine("You are so dumb");
    Console.WriteLine("You could not even write that easy word");
    Console.ReadLine();
}



Console.WriteLine("hahaha you thought you were done but ther are a couple more questions");
Console.WriteLine("The things I need for an ideal night");
    string[] FunNight = 
{
    "Cola", "Chips", "Candy", "Movies"
};
 for (int i = 0; i < FunNight.Length; i++)
 {
    Console.WriteLine(FunNight[i]);
 }

Console.WriteLine("Name 4 things you need for an ideal night");
    string[] YourNight = new string[4];
 for (int i = 0; i < FunNight.Length; i++)
{
    YourNight[i] = Console.ReadLine();
}

Console.WriteLine("That sounds like a fun night, wish I could join in");

Console.WriteLine("Now we should get continue with the things we need done");

static void guessing()
{
    Random numberGen = new Random();

    string Street = "Yonge Street " + numberGen.Next(1, 1000);
    int age = numberGen.Next(5, 100);
    int house = numberGen.Next(1, 10);


    Console.WriteLine("You live at " + Street);
    Console.WriteLine("You are " + age + " years old");
    Console.WriteLine("And you live " + house + " people in your house");
}

    Console.WriteLine("Hi, now we have come to my guessing game");
    Console.WriteLine("where I guess things about you");
    guessing();
    Console.ReadLine();

    Console.WriteLine("Now that there was probably only 1 of them that I did not get right I will try again");
    guessing();
    Console.ReadLine();

    Console.WriteLine("I was probaly right this time");

string c = Console.ReadLine();
bool Guessinggame = false;
if (c == "yes"){
    HardWord = true;
}

if (Guessinggame == false){
    Console.WriteLine("So that was not right either but I promise you this time I will be right");
    Console.WriteLine("Well third time is the lucky time");
    guessing();
    Console.WriteLine("I knew I was right this time");
    Console.ReadLine();
}

if (Guessinggame == true){
    Console.WriteLine("I knew I was right this time");
}

#endregion


    Console.WriteLine("...The end...");
    Console.ReadLine(); //Stops program from exiting until we press a key
