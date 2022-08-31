
var myPlayer = new Player();
Console.WriteLine("Hello, What is your name?!");

myPlayer.Name = Console.ReadLine();

Console.WriteLine($"Your name is {myPlayer.Name}");

myPlayer.NumberInParty = 0;

while(myPlayer.NumberInParty < 1)
{
    Console.WriteLine("How many people are joining you on your adventure - including yourself? There must be at least one of you to start the adventure!");
    string numberInPartyString = Console.ReadLine();


    bool canConvertToInt = int.TryParse(numberInPartyString, out int parsedInt);

    myPlayer.NumberInParty = parsedInt;

    if (canConvertToInt)
    {
        Console.WriteLine($"You have {myPlayer.NumberInParty} people in your party");
    }
    else
    {
        Console.WriteLine("Give me an actual integer!!");
    }
}

Console.WriteLine($"{myPlayer.Name}, you have {myPlayer.NumberInParty} people in your party and you may begin your adventure!!");



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