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
            Console.WriteLine("Pleae enter an intergery between 1 and 25:");
            /*
             Use the try catch block to validate user input
             If the user provides bad input, the catch block
             will handle the erroe and a message will displayed.
            */
            try
            {
                //This variable will gather data form user input
                string input = Console.ReadLine();
                // This variable wil lbe used to perform the various itertive statements and is parsed as n integer
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 25, manually populate an array and iterate throught its values
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, lets manually populate an array with integers");
                    Console.WriteLine("Then, lets iterate through the elemts in the array with a foreach loop");
                    //Here is the manually populated array
                    int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                    Console.WriteLine("________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number:" + value_of_input);
                    Console.WriteLine("The value is" + numbers[value_of_input]+ "in element #" + value_of_input +"of the array.");
                    Console.WriteLine("Here are the values in each element of the array:");
                    Console.WriteLine("________________________________");
                    Console.WriteLine("");
                    // Iterate throguh the array with Froeach Loop
                    foreach (int i in numbers)
                    {
                        Console.Write(i + "");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("_____________________________");
                    Console.WriteLine("Press any key to exit the program...");
                    //Pause the program and await the user to the press a key to end the program
                    Console.ReadKey(true);
                }// End of else if
                // If the uer seleces a number that is not betwween 1 and 20, display message
                else
                {
                    Console.WriteLine("Please enter an inegrey value between 1 and 25 next time...");
                    Console.WriteLine("Press any key to exit the pgroam and try again...");
                    Console.ReadKey(true);
                }// End of else
            }//End of try
            // If a suer does not enter inegrey, display a message
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Presss any ket to exit the program and try again...");
                Console.ReadKey(true);
            }// End of catch
        }
    }
}
