using System.Collections.Generic; // this line is required to use a List or any other standard collection ('using System' is always required)
                                  // adding 'Collections.Generic' is like using 'import' in Python
class Program
{
    static void Main(string[] args)
    {
        // use 'new' keyword and declare data type when creating a list
        List<int> numbers = new List<int>();
        List<string> words = new List<string>(); // parenthesis used when creating an object

        words.Add("phone"); // 'Add' is equivalent to 'append' in Python
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count); // 'Count' same as 'len' in Python - no () used with 'Count' because is a property, not function

        foreach (string word in words) // iterate through list using 'foreach' loop
        {
            Console.WriteLine(word);
        }

        for (int i = 0; i < words.Count; i++) // iterate using 'for' loop and index value
        {
            Console.WriteLine(words[i]);
        }
    }
}