using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {

        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        
                /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            do
            {
              
               Console.WriteLine(" Enter + for add (+Name)\n Enter - for remove (-Name)\n Q for quit");
                string input = Console.ReadLine()!;
                char nav = ' ';
                string value = "";
                try
                {
                    nav = input[0];    //Validate
                  value = input.Substring(1);

                }
                catch (Exception)
                {
                    Console.WriteLine("epmty input");
                }

                //  nav = input[nav];

                switch (nav)
                {
                    case '+':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to add");
                            break;
                            //No value

                        }
                        else
                        {
                            theList.Add(value);
                            Console.WriteLine($"List has Capacity: {theList.Capacity} And contains of {theList.Count} items");
                        }
                        break;
                    case '-':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to add");
                            break;
                            //No value

                        }
                        else
                        {
                            theList.Remove(value);
                            Console.WriteLine($"List has Capacity: {theList.Capacity} And contains of {theList.Count} items");
                        }

                        break; 
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("Please enter only one of these operators(+, -) followed by a name");
                        break;

                }

            } while (true);



        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
           
            Queue myQ = new Queue();
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            do
            {

                Console.WriteLine(" Enter 'E' or 'D' to test the queue\n Enter Q to exit");
                string input = Console.ReadLine()!;
                char nav = ' ';
                string value = "";
                try
                {
                    nav = input[0];    //Validate
                    value = input.ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine("Epmty input");
                }

                //  nav = input[nav];

                switch (nav)
                {
                    case 'E':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to add");
                            break;
                            //No value

                        }
                        else
                        {
                            myQ.Enqueue(value);
                            Console.WriteLine("Total elements present in queue: {0}", myQ.Count);


                        }
                        break;
                    case 'D':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to add");
                            break;
                            //No value

                        }
                        else
                        {
                            myQ.Dequeue();
                            Console.WriteLine("Total elements present in queue: {0}", myQ.Count);
                        }

                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("nothing added");
                        break;

                }

            } while (true);


        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            
            Stack mySt = new Stack();
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            do
            {
                Console.WriteLine(" Enter a letter by 'p' to push\n Enter 'dd' to pop stack elements\n Enter Q to exit");
                string input = Console.ReadLine()!;
                char nav = ' ';
                string value = "";
                try
                {
                    nav = input[0];    //Validate
                    value = input.Substring(1);
                }
                catch (Exception)
                {
                    Console.WriteLine("Epmty input");
                }

                switch (nav)
                {
                    case 'p':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to push");
                            break;
                            //No value

                        }
                        else
                        {
                            mySt.Push(value);
                            Console.WriteLine("Total elements present in stack: {0}", mySt.Count);
                            foreach (var item in mySt)
                            Console.WriteLine(item);



                        }
                        break;
                    case 'd':
                        if (value.Length <= 0)
                        {
                            Console.WriteLine("No value to add");
                            break;
                            //No value

                        }
                        else
                        {
                            mySt.Pop();
                            Console.WriteLine("Total elements present in stack: {0}", mySt.Count);
                            foreach (var item in mySt) { Console.WriteLine(item.ToString()); }
                        }

                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("nothing added");
                        break;
                }



            } while (true);

        }

        
        static void CheckParanthesis()
        {
            
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //Jag kunde inte hitta en bra lösning för den här delen av övning4
        }
        
    }
}

