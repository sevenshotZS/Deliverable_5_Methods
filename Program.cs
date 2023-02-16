/* 
 Author: Zack Slezak
 Date: 2/16/2023
 Comments: This C# Console application code demostrates the use 
           of two methods: 
           (1) Randomly populating an array with integers numbers between 10 and 50
           (2) Returning the summation of all the elements of an array
*/

using System;
namespace Deliverable_5_Methods
{
    internal class Program
    {
     
            //Generates an a random array
            static int[] random_array(int array_len)
            {
            
               Random random = new Random();
               int[] MyArray = new int[array_len];
               for (int i = 0; i < array_len; i++)
               {
                   MyArray[i] = random.Next(10, 50);
               }

               return MyArray;
               
           
            }
            //Calculates the sum of the array's attributes
            static int sum(int[] array)
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum = sum + i;
                }
                return sum;
            }

            //Implements both methods
            static void Main(string[] args)
            {
            try { 
                    Console.WriteLine("Enter an integer number between 5 and 15 and then push enter");
                    int input = int.Parse(Console.ReadLine());

                    int[] MyArray = random_array(input);

                    Console.Write("The elements in the random array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + sum(MyArray));
                }

            catch {
                Console.WriteLine("ERROR: Please enter an integer within the parameters");
                  }
        





            }
    }
}