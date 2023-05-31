using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IT391U2B
{
    class PartBU2Assignment
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 2, Part B, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 **********");
            Console.WriteLine();

            //Executing queue
            Customers();
            Console.ReadKey();
            //*********************************************************
            //****Assignment 2, Part B, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 2 **********");
            Console.WriteLine();

            //Taking user input for sentance
            Console.WriteLine("Please enter a sentance: ");
            string userinput = Console.ReadLine();
            Console.WriteLine();

            //Executing user input sentance in reverse order but readible.
            revSentance(userinput);
        }

        //Stack method to return sentance in reverse
        private static void revSentance(string str)
        {
            Stack<string> newStack = new Stack<string>();

            string[] sentance = str.Split();
            for (int i = 0; i < sentance.Length; i++)
                newStack.Push(sentance[i]);
            for (int i = 0; i < sentance.Length; i++)
                Console.WriteLine(newStack.Pop());
        }

        //Bank Queue method
        private static void Customers()
        {
            //Creating customer queue
            Queue customers = new Queue();
            //Load the queue with names
            customers.Enqueue("Jane");
            customers.Enqueue("Bob");
            customers.Enqueue("Liza");
            customers.Enqueue("Tom");
            customers.Enqueue("Mary");

            //Displaying number of shoppers and names
            Console.WriteLine("The number of people at the bank is, " + customers.Count);
            Console.WriteLine("The names of those in line at the bank are ");

            //Created loop for customer names to display
            foreach (string Customername in customers)
                Console.WriteLine(Customername);
            Console.WriteLine();

            //Displaying first customer in line
            Console.WriteLine("The first customer in line is, " + customers.Peek());
            //Removing customer from queue
            customers.Dequeue();

            //Adding two customers
            customers.Enqueue("Andy");
            customers.Enqueue("Rhonda");

            //Removing three more customers
            customers.Dequeue();
            customers.Dequeue();
            customers.Dequeue();

            //Displaying new size of queue line
            Console.WriteLine("The number of customers in line now is, " + customers.Count);
        }
    }
}
