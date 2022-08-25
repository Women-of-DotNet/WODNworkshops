
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

Open the `Program.cs` file; this is the entry point of our application and it will look like this:

```csharp
Console.WriteLine("Hello World!");
```
It has a `Program` class with a `Main` method inside it.

The `Console.WriteLine("Hello World!");` is what printed "Hello World!" inside our console.  Change the contents of the `"` marks to say `"Hello, what is your name?"` as shown below.

```csharp
Console.WriteLine("Hello, what is your name?");
```
Now if we run the project from the console, using `>dotnet run` again, you should see that our question is printed to the console instead.

## What's going on?
.NET comes with a whole load of ready-made code us to use in the form of *libraries*. Behind the scenes, there is an implicit library called `System` and many others. Inside these libraries, we have methods or functions that we can use or call. We can also add more libraries via a service called "NuGet".

`Console.WriteLine();` is a method from the `System` library that, in this case, takes a *string* and then writes or prints that string to the console.

## What's a *string*?
C# is what's known as a *strongly-typed* language. A *string* is a type. It means that the contents will be treated as text.  There are many types and you can create your own types, often called *models* or *classes*.

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

So in this workshop, we have learned to take input from a user, assign that to a variable and then combine that input with another string, outputting that to the screen!


