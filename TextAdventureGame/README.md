
# Creating your first console application
## Introduction
In this workshop, we will create a basic application called a console application. This is an app that runs on the terminal, sometimes known as the console or command line.
On a Windows machine, we can use the cmd or Powershell as our console.
On Linux, it's the terminal.
And on macOS, it's also terminal or you can download iTerm and use that instead.

We will also be using the command line to create and run our application.

## Setting up our development environment.

To get started with C# we will need to download a Software Development Kit, or SDK. C# runs on a framework called .NET (dot net) and we will download the .NET SDK [here](https://dotnet.microsoft.com/download).
Choose the correct download for your operating system, e.g. Windows, and follow the installation instructions.

We will also need a code editor to enable us to edit our code.  [Visual Studio Code](https://code.visualstudio.com/download) is a free and very versatile editor, so let's download that one, again, choosing the right download for your operating system.

To check if the .NET SDK installed correctly, open the terminal and type in `dotnet` and press enter.
You should see something similar to this
<br/><br/>
SCREENSHOTS
![image showing dotnet in the console](/images/workshops/dotnet-check.png)
<br/><br/>
Now that we know the SDK is installed correctly we can make our first application.
When you open the terminal it will most likely open in a certain folder or directory on your computer.
If you type in `ls` and press enter, you should see a list of all the folders and files in the current directory.  It may look something like this:
<br/><br/>
SCREENSHOTS
![image showing contents of new console app](/images/workshops/ls-console.png)
<br/><br/>
We need to create a new directory for our code to live in.
To make a new directory we will use the following command:

```bash
>mkdir Repos
```
</br>
Repos is short for repositories.  A repository is a place where your coding files can be stored.

If you type in `ls` again, you should see we now have a new directory called Repos.
We now need to change directory (cd) so that our terminal is inside our new folder.

```bash
>cd Repos
```
</br>
Now we are in the right folder, let's create a new .NET project.

```bash
>dotnet new
```
SCREENSHOTS
<br/><br/>
![image showing dotnet new in the console](/images/workshops/dotnet-new.png)
<br/><br/>
The above command will bring up all the available templates projects that came with the SDK.  We want to build a console app, so enter the following command:
</br>
```bash
>dotnet new console -n Adventuring
```
</br>

This command will create a new Directory called `Adventuring` and add a new console application inside it.
If cd into the `Adventuring` directory and list all the files we will see with have 2 files called `Program.cs` and `Adventuring.csproj`.
<br/><br/>
SCREENSHOTS
![image showing contents of new console app](/images/workshops/ls-console.png)
<br/><br/>
We now have a basic application that we can run.
Type in the following command:
```bash
>dotnet run
```
</br>
CHECK
And we should see that "Hello World!" is printed in the console.

We have made our first program!
</br></br>
Let's go edit our program!

# Writing code

Open the `Program.cs` file; this is the entry point of our application and it will look like this:

```csharp
Console.WriteLine("Hello World!");
```
It has a `Program` class with a `Main` method inside it.

The `Console.WriteLine("Hello World!");` is what printed "Hello World!" inside our console.  Change the contents of the `"` marks to say `"Hello, what is your name?"` as shown below.

```csharp
// Ask the user to input a name - this a comment!
Console.WriteLine("Hello, what is your name?");
```
Now if we run the project from the console, using `>dotnet run` again, you should see that our question is printed to the console instead.

## What's going on?
.NET comes with a whole load of ready-made code us to use in the form of *libraries*. Behind the scenes, there is an implicit library called `System` and many others. Inside these libraries, we have methods or functions that we can use or call. We can also add more libraries via a service called "NuGet".

`Console.WriteLine();` is a method from the `System` library that, in this case, takes a *string* and then writes or prints that string to the console.

## What's a *string*?
C# is what's known as a *strongly-typed* language. A *string* is a type. It means that the contents will be treated as text.
These types are simple, meaning they have one value (they are often called *value types*).
There are many types and you can create your own more complex types, often called *object*,  *models*, or *classes* - depending on where they are used.

Let's see if we can get input from the console.

Update code inside your `Program` file to the following:

```csharp
Console.WriteLine("Hello, what is your name?");
string name;
name = Console.ReadLine();
Console.WriteLine("Your name is " + name);
```
<br/><br/>
Now we have *declared* a *variable* called `name`, of type *string*. Whatever we type into the console will be stored in this variable because we have *assigned* the output of `Console.ReadLine` to it.

We then use another call to `Console.Writeline()` this time passing in a *string* and our variable, which is also a *string*.  We can use the `+` sign to combine these.

## Improving what we have
The above code is okay but we can make it a little bit better. This is called *refactoring*.
We can do a declaration and assignation on one line so we now have:
```csharp
string name = Console.ReadLine();
```
<br/><br/>
.NET is clever and most of the time it can tell what type a variable is so instead of `string` we can use `var`.

```csharp
var name = Console.ReadLine();
```
<br/>
We can also tidy up the last line of code using *string interpolation*: so 
```csharp
Console.WriteLine("Your name is " + name);
```
<br/>
becomes:
```csharp
Console.WriteLine($"Your name is {name}");
```
<br/>
Which makes the code a bit more readable.

## Other types

The next type we are going to look at is *int* which is short for integer (a whole number).
Let's start by asking the user for a number.

```csharp
Console.WriteLine("How many people are joining you on your adventure - including yourself? There must be at least one of you to start the adventure!");
string numberInPartyString = Console.ReadLine();
```
> Note that the response we get from the user will be a *string. So how do we make it a number?

To convert a string to a number, we need to use a method from a library. This time we will use `TryParse()`. In this instance, we will specifically use `int.TryParse`. This method will take a string, if it can convert it to a number it will return `true` and the `int`, otherwise it will return false.

> `true` and `false` are types known as *bools* or *booleans*.

After we get the value of `numberString` from the user, add the following code:

```csharp
bool canConvertToInt = int.TryParse(numberInPartyString, out int numberInParty);
```
`canConvertToInt` will either be *true* or *false*. If *true*, the variable `numberInParty` will be our converted *string* as an *int*.

For example, if the user inputs the word "three" instead of the number "3", the `canConvertToInt` will be *false*, otherwise it will be *true*.

# Conditional logic

To act on our *true* or *false* we will need to add some conditional logic which will help us control the flow of our project. 

## If else statement
The first statement we'll use is an *if/else* statement (boolean predicate).

Add the following to your code:

```csharp
if(canConvertToInt)
{
    Console.WriteLine(numberInParty);
    Console.WriteLine($"You have {numberInParty} people in your party");
}
else
{
    Console.WriteLine("Give me an actual integer!!");
}
```

But, we have a problem.

If we can't get an integer from the input, our code currently doesn't ask the use to reenter, the program just ends. We will need to update our code!

## While statement
To get our program to ask the user for a number again, we will use a *while* statement. This will need a statement of "truth-i-ness" - meaning *while something is true, do this thing*.

Replace your code from where we asked for the number of people in the party to look like this:

```csharp

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
```
In the above code, we declare the *int* `numberInParty` as zero. We then have a *while* statement that will ask for a number until `numberInParty` is greater than zero. Once the number is greater than zero, the program will continue.

# Custom types

As mentioned earlier, you can create your own custom type, called an *object*, *model*, or *class*. We'll call it a *object* for now.
We have a couple of inputs from the user -- *name* and *number in party*. To emanage this data better, we can create a *player* type that stores this data in one place. 

FURTHER EXPLANATION OF OBJECTS - HOW THEY ARE TEMPLATES AND NEED TO BE INSTANTIATED

We could add this *class* in our "Program.cs* but to keep our code tidy, let's add it as a new file.

Click the add new file icon in VS code to add a new file and call it "Player.cs".
SCREENSHOT
Open the file and add the following:

```csharp
public class Player
{
    public string Name {get; set;}
    public int NumberInParty {get;set;}
}
```

We can now update the code in "Program.cs" with our *Player* object, creating a new instance of it.

At the top of the file write the following line:

```csharp
var myPlayer = new Player();
```
There are several ways to *new* up an object, but we don't need to worry about that now.

We can now replace the variables `name` and `numberInParty` with `myPlayer.Name` and `myPlayer.NumberInParty` respectively.

`myPlayer` is now a container for data about the specific user of our game.

Our "Program.cs" file should now look like this:

```csharp

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



```

To finish let's add the follwong line at the end of our code:

```csharp
Console.WriteLine($"{myPlayer.Name}, you have {myPlayer.NumberInParty} people in your party and you may begin your adventure!!");
```