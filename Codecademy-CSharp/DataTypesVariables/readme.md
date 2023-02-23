# Introduction to Data Types and Variables in C#

When we write programs, we’re telling the computer how to process pieces of information, like the numbers in a calculation, or printing text to the screen. So how does a computer distinguish between a number and a character? Why is it important to be able to tell the difference?

Languages like C# tell a computer about the type of data in its program using data types. Data types represent the different types of information that we can use in our programs and how they should be used.

Without data types, computers would try and perform processes that are impossible, like squaring a piece of text or capitalizing a number. That’s how we get bugs!

C# is strongly-typed, so it requires us to specify the data types that we’re using. It is also statically-typed, which means it will check that we used the correct types before the program even runs. Both language features are important because they help write scalable code with fewer bugs.

## C# Data Types

Data types tell us a few things about a piece of data, like:

- How it can be stored
- What operations we can perform with it
- Different methods it can be used with

Data types are present in all programming languages, but are particularly important in C#. That’s because C# is known as a **strongly-typed language** — it requires that the programmer specify the data type of every value and expression. While it means writing more code, using types has long term benefits like built-in documentation and increased readability.

## Creating Variables with Types

When we use data in our programs, it’s good practice to save them in a variable. A variable is basically like a box in our computer memory where we can store values used in our code.

In C#, data types and variables are closely intertwined. 

Remember how C# is strongly-typed? Every time we declare a variable, we have to specify what kind of data type that variable is going to hold.

There are two ways we can assign variables. We can do it on two lines:

// Declare an integer

int myAge;

myAge = 32;

Or, we can be more concise and just do it on one:

// Declare a string

string countryName = "Netherlands";

In each case, we first write the data type, then the variable name, then use the equals sign = to assign the variable a value.

Once we’ve defined a variable, we can use them throughout our program. For example, here’s a short program that prints a few math equations to the console:

*int evenNumber = 22;*

*int oddNumber = 45;*

*Console.WriteLine(evenNumber + oddNumber); // Prints 67*

*Console.WriteLine(oddNumber - evenNumber); // Prints 23*

If we want to change the values, it’s only necessary to change it in one place instead of everywhere it is used.

