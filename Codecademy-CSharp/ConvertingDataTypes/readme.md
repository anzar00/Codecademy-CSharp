# Converting Data Types

Because variables have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.

For example, let’s try converting a double to an integer:
<pre>
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = myDouble;
</pre>

But if you tried to run this code, it wouldn’t work. Sorry.

However, if you did the reverse and turned an int into a double:
<pre>
int myInt = 3;
// Turn it into a double
double myDouble = myInt;
</pre>

It’s fine! Why is that?

C# checks to make sure that when we convert data types from one to another that we’re not losing any data, because that could cause problems in our code.

Because of that, there are a couple different ways to do data type conversion:

- **implicit conversion** : happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.

- **explicit conversion** : requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).

So, if we’re to fix the error in our previous code, we’d rewrite it as follows:

<pre>
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = (int)myDouble;
</pre>

It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble().