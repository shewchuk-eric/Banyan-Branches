using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayMessage() // first declare the type of function - void does not return anything
        {
            Console.WriteLine("Hello World!");
        }

        void DisplayPersonalMessage(string userName) // parameters must declare the data type
        {
            Console.WriteLine($"Hello {userName}");
        }

        int AddNumbers(int first, int second) // this function will return an integer and both parameters are declared as integer data types
        {
            int sum = first + second;
            return sum;
        }

        // most functions will actually be methods which means they'll only be called in the context of an object
        // to create a function that will be 'standalone' you'll need the 'static' keyword
        static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }
        // variable scope is same as Python - a variable declared inside a function doesn't exist outside it
    }
}