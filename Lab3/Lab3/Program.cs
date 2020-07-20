using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            bool parseSuccess = false;
            //int userInput;
            //int tempUserInput;

            while (continueProgram)
            {

                Console.WriteLine("Enter a number between 1 and 100: ");
                // var userInput = int.Parse(Console.ReadLine());

                
                while (parseSuccess == false)
                {
                    int userInput;
                    
                    parseSuccess = int.TryParse(Console.ReadLine(), out int tempUserInput);
                    

                    if (parseSuccess)
                    {
                        userInput = tempUserInput;

                        //Makes sure user entry is between 1 and 100
                        while (userInput < 1 || userInput > 100)
                        {
                            Console.WriteLine($"\n{userInput} is not a valid entry. Please enter a number between 1 and 100:");
                            userInput = int.Parse(Console.ReadLine());
                        }
                        //For all odd cases
                        if (userInput % 2 == 1)
                        {
                            Console.WriteLine("\n~~~~~~~~~~~~~~~");
                            Console.WriteLine($"Output: {userInput}, Odd");
                            Console.WriteLine("~~~~~~~~~~~~~~~\n");
                        }
                        //For even cases between 2 and 25
                        else if (userInput >= 2 && userInput <= 25)
                        {
                            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"Output: Even and less than 25");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                        }
                        //For even cases between 26 and 60
                        else if (userInput >= 26 && userInput <= 60)
                        {
                            Console.WriteLine("\n~~~~~~~~~~~~");
                            Console.WriteLine($"Output: Even");
                            Console.WriteLine("~~~~~~~~~~~~\n");
                        }
                        //For even cases greater than 60
                        else
                        {
                            Console.WriteLine("\n~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"Output: {userInput}, Even");
                            Console.WriteLine("~~~~~~~~~~~~~~~~\n");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nNot a valid entry.\nPlease enter a number between 1 and 100:");
                       // int.TryParse(Console.ReadLine(), out tempUserInput);
                        //userInput = tempUserInput; 
                    }
                }

                //Determines if user would like to continue using program
                Console.WriteLine("Continue? (y/n)");
                var continueInput = Console.ReadLine();
                Console.WriteLine();

                while(continueInput.ToLower() != "y" && continueInput.ToLower() != "n")
                {
                    Console.WriteLine($"{continueInput} is an invalid entry. Please select y or n:");
                    continueInput = Console.ReadLine();
                    Console.WriteLine();
                }
                if(continueInput.ToLower() == "n")
                {
                    Console.WriteLine("The program is ending.");
                    continueProgram = false;
                }
                else
                {
                    parseSuccess = false;
                }
            }
        }
    }
}
