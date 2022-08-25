Console.WriteLine("Hello, What is your name?!");

var name = Console.ReadLine();

Console.WriteLine($"Your name is {name}");

int numberInParty = 0;

while(numberInParty < 1)
{
    Console.WriteLine("How many people are joining you on your adventure - including yourself? There must be at least one of you to start the adventure!");
    string numberInPartyString = Console.ReadLine();


    bool canConvertToInt = int.TryParse(numberInPartyString, out numberInParty);

    if (canConvertToInt)
    {
        Console.WriteLine($"You have {numberInParty} people in your party");
    }
    else
    {
        Console.WriteLine("Give me an actual integer!!");
    }
}





// http://plugh.com/

// https://github.com/spectreconsole/spectre.console
// https://github.com/lastunicorn/ConsoleTools
// different ways to new (instantiate) a user
// User user = new User();
// var anotherUser = new User();
// User anotherAnotherUser = new ();
// User nonInstantiatedUser;
// User nullUser = null;


// using NuGet - bring in ConsoleTools library
// loops| and conditional logic
// variables
// types
// classes

// try{}catch(Exception ex){}finally{

// }

// List<int> eyeballs = new();

// foreach(var eye in eyeballs)
// {

// }
// while(true){

// }

// do{

// }while(true);