Console.WriteLine("Hello, What is your name?!");
// https://github.com/spectreconsole/spectre.console
// https://github.com/lastunicorn/ConsoleTools
// different ways to new (instantiate) a user
User user = new User();
var anotherUser = new User();
User anotherAnotherUser = new ();
User nonInstantiatedUser;
User nullUser = null;

var name = Console.ReadLine();

user.Name = name;

Console.WriteLine($"Your name is {name}");

// using NuGet - bring in ConsoleTools library
// loops| and conditional logic
// variables
// types
// classes

Console.WriteLine("How many eyeballs do you have?");

string numberOfEyeballsString = Console.ReadLine();


bool isItANumber = 
    int.TryParse(numberOfEyeballsString, out int numberOfEyeBalls);

if(isItANumber)
{
  Console.WriteLine(numberOfEyeBalls);
  Console.WriteLine($"You have {numberOfEyeBalls} many eyeballs");
}
else if (true){

}
else
{
Console.WriteLine("Give me an actual integer!!");
}

try{}catch(Exception ex){}finally{

}

List<int> eyeballs = new();

foreach(var eye in eyeballs)
{

}
while(true){

}

do{

}while(true);