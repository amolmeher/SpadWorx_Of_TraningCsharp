using System;
using System.Collections;

class GFG
{

    // Main Method
    static public void Main()
    {
        Stack my_stack = new Stack();

        my_stack.Push("Geeks");
        my_stack.Push("geeksforgeeks");
        my_stack.Push('G');
        my_stack.Push(null);
        my_stack.Push(1234);
        my_stack.Push(490.98);

        foreach (var elem in my_stack)
        {
            Console.WriteLine(elem);
        }
    }
}