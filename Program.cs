using System;

namespace Tech_Project_3B
{
    class Program
    {
        /*
         Author: Antonio Jones
         Date: 9/27/2020
         Comments: This C# Console application code demonstrates the use of
         Arrays after getting input from users. 
        */
        static void Main(string[] args)
        {
            // No User Input
            Console.WriteLine("");
            Console.WriteLine("Executing a For Value!");
          
                //If the value of user input between 1 and 25, maually populate an array and iterate through its values
                int pop_array = 0;
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, lets manually populate an array with integers");
                    Console.WriteLine("Then, lets iterate through the elements in the array with a foreach loop");
                    //Here is the manually populated array
                    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                    Console.WriteLine("________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Element:");
                    Console.WriteLine("The value is" + numbers[pop_array]+ "in element #" + pop_array +"of the array.");
                    Console.WriteLine("Here are the values in each element of the array:");
                    Console.WriteLine("________________________________");
                    Console.WriteLine("");
                    // Iterate through the array with Foreach Loop
                    foreach (int i in numbers)
                    {
                        Console.Write("Element Value =" + i + (" "));
                    }
                    Console.WriteLine("");
                    Console.WriteLine("_____________________________");
                    Console.WriteLine("Press any key to exit the program...");
                    //Pause the program and await the user to the press a key to end the program
                  
                }
          
        }
    }
}
