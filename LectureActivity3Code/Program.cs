/*
* Author: Ruben Villagrana
* Course: COMP-003A
* Purpose: Lecture Activity 3 Code
*/

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("conditional (selection) statements");
            Console.WriteLine("**********************************");
            /******************************************************/

            Console.WriteLine("1. single if statement");
            Console.WriteLine("\tEnter a whole positive nuber:");
            int inputNumber = Convert.ToInt32(Console.ReadLine()); // store user input as an integer

            // single if statement
            if (inputNumber % 2 == 0)
            {
                // this code block executes if the conditions about is true 
                Console.WriteLine("\tinputNumber is even");
            }

            /************************************************************/
            Console.WriteLine("2. if-else statement");
            // if-else statement
            if (inputNumber % 2 == 0)
            {
                //this code block executes if the conditions about is true
                Console.WriteLine("\tinputNumber is even");
            }
            else
            {
                //this block executes if the above condition is false
                Console.WriteLine("\tinputNumber is odd");
            }

            /******************************************************************/
            Console.WriteLine("3. nested if statement");
            // nested if statements
            if (inputNumber % 2 == 0)
            {
                // this code blocks executes if the inputNumber is divisible by 2
                Console.WriteLine("\tinputNumber is even");

                if (inputNumber % 5 == 0)
                {
                    // this code block executes if the inputNumber is 
                    // divisible by 2 first, and divisible by 5 after
                    Console.WriteLine("\t\tinputNumber is also divisible by 5");
                }
                else
                {
                    // this code block executes if the inputNumber is 
                    // divisible by 2 first, and Not divisible by 5 after
                    Console.WriteLine("\t\tinputNumber is Not divisible by 5");
                }
            }
            else
            {
                // this code block executes if the inputNumber is Not divisible by 2
                Console.WriteLine("\t\tinputNumber is odd");
            }

            /************************************************************************/

            Console.WriteLine("4. multiple if-else statements");
            // multiple if-else statements
            if (inputNumber % 2 == 0)
            {
                //this code block executes if the above condition is true
                // the rest of the conditions will not longer execute
                Console.WriteLine("\tinputNumber is divisible by 2.");
            }
            else if (inputNumber % 3 == 0)
            {
                // this code block executes if the above condition is true
                // the rest of the condition will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 3.");
            }
            else if (inputNumber % 5 == 0)
            {
                // this code block executes if the above condition is true
                // the rest of the condition will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 5.");
            }
            else if (inputNumber % 7 == 0)
            {
                // this code block executes if the above condition is true
                // the rest of the conditon will no longer execute
                Console.WriteLine("\tinputNumber is disivible by 7. ");
            }
            else
            {
                // this code block executes if the conditions are Not true
                Console.WriteLine("\tinputNumber is not divisible by 2/3/5/7.");
            }

            /*********************************************************************/

            Console.WriteLine("5. ternary operator");
            string outputMessage = inputNumber % 2 == 0
                ? "\tinputNumber is even."
                : "\t inputNumber is odd";
            Console.WriteLine(outputMessage);

            /************************************************************************/

            int randomNumber = new Random().Next(10); // generates a random number 10 or below
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber != randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber > randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber < randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber <= randomNumber}");

            /**********************************************************************************/

            Console.WriteLine("7. logical operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} && {inputNumber} >= {randomNumber}:" +
                $"{inputNumber == randomNumber && inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} || {inputNumber} >= {randomNumber}:" +
                $"{inputNumber == randomNumber || inputNumber >= randomNumber}");
            Console.WriteLine($"\t! (true): {!(true)}");

            /**********************************************************************************************/

            Console.WriteLine("8. switch statement");
            //switch statement
            switch ( inputNumber ) 
            {
                case 2:
                    //this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is divisible by 2.");
                    break; // the break keyword exits out of the switch
                case 3: 
            }

        }
    }
}