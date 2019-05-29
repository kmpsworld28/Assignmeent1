using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the Calculate class
            Calculate c = new Calculate();
            bool validInput = false;
            string calcSelection;
            int selection;

            //Loop until proper is input to continue execution is got
            while (validInput == false)
            {
                Console.WriteLine("Do you want to Enter Rectangle calculation Program (Y/N)\n");
                Console.WriteLine("Please Enter Y or N to continue\n");

                calcSelection = Console.ReadLine();
                Console.WriteLine();
                //Validate for invalid input
                if (calcSelection != "Y" && calcSelection != "N" && calcSelection != "y" && calcSelection != "n")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (calcSelection.Equals("Y") || calcSelection.Equals("y"))
                {
                    validInput = true;

                    int firstNumber;
                    int secondNumber;
                    //Validate inputs
                    firstNumber = sanitizeUserInput("Length");
                    secondNumber = sanitizeUserInput("Width");

                    Console.WriteLine($"Your inputs are {firstNumber} and {secondNumber}.\n");
                    //Setting values with the input params using paramterized constructor.
                    Calculate customCalc = new Calculate(firstNumber, secondNumber);
                    c = customCalc;
                }
                else if (calcSelection.Equals("N") || calcSelection.Equals("n"))
                {
                    System.Environment.Exit(-1);
                }
            }

            //Get menu option input
            selection = getMenuInput();
            //Loop utill selection is not exit
            while (selection != 7)
            {
                int result;
                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length of Rectangle is: {c.GetLength()}\n");
                        break;
                    case 2:
                        result = sanitizeUserInput("Length");
                        c.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width of Rectangle is: {c.GetWidth()}\n");
                        break;
                    case 4:
                        result = sanitizeUserInput("Width");
                        c.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Area of [{c.GetLength()} x {c.GetWidth()}] Rectangle is: {c.GetArea()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The Perimeter of [{c.GetLength()} x {c.GetWidth()}] Rectangle is: {c.GetPerimeter()}\n");
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
                selection = getMenuInput();

            }

        }

        //Public funtion to Validate Menu input
        public static int getMenuInput()
        {
            string getUserInput = "";
            bool flagSet = false;
            //Loop until Proper range values are not attained.
            while (flagSet == false)
            {
                Console.WriteLine("ENTER");
                Console.WriteLine("1. To Fetch Rectangle Length");
                Console.WriteLine("2. To Update Rectangle Length");
                Console.WriteLine("3. To Fetch Rectangle Width");
                Console.WriteLine("4. To Update Rectangle Width");
                Console.WriteLine("5. To get Rectangle Area");
                Console.WriteLine("6. To get Rectangle Perimeter");
                Console.WriteLine("7. To get EXIT");

                Console.WriteLine("Please enter values between 1-7 to proceed");
                getUserInput = Console.ReadLine();

                if (getUserInput != "1" &&
                     getUserInput != "2" &&
                     getUserInput != "3" &&
                     getUserInput != "4" &&
                     getUserInput != "5" &&
                     getUserInput != "6" &&
                     getUserInput != "7")
                {
                    Console.WriteLine("Not a valid menu input option. Please try again");
                }
                else
                {
                    flagSet = true;
                }
            }
            Console.WriteLine();
            //Return Integer parsed input results
            return int.Parse(getUserInput);

        }
        //Public function to validate Input for Length and Width of the triangle.
        public static int sanitizeUserInput(string inputNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {inputNumber}:");
                string getUserInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(getUserInput, out aNumber);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Your {inputNumber} has been changed to: {aNumber}.\n");
                }
            }
            return aNumber;
        }
    }
}
