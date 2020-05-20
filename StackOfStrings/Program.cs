using System;
using System.Collections;

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            string s1 = "Hej";
            string s2 = "Hej2";
            string s3 = "Hej3";

            stackOfStrings.Push(s1);
            stackOfStrings.Push(s2);
            stackOfStrings.Push(s3);

            Console.WriteLine("Rätt svar: false, true, hej2, true, true, true\n");

            Console.WriteLine(stackOfStrings.IsEmpty());//false
            Console.WriteLine(stackOfStrings.Pop());//true
            Console.WriteLine(stackOfStrings.Peek());//Hej2
            Console.WriteLine(stackOfStrings.Pop());//true
            Console.WriteLine(stackOfStrings.Pop());//true
            Console.WriteLine(stackOfStrings.IsEmpty());//true
        }
    }
}
