using System;

namespace Multiplication_Table_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiplication table - C# CRL version.cpp : main project file.

    int row = 0;// The first varible called row with a value of 0
	int column = 0;//Second varible called column with a value of 0
	Console.WriteLine("\t\t\tMultiplication Table\n\n\n");//we are outputting to the screen via .net framework WriteLine will create a newline 
	Console.Write ("     ");//Write outputs without a newline character
	for (row = 1; row !=11; row++)//The first loop, this will create 1 through 10 across the top of the screen
	{
		Console.Write ("{0,5}", row);//First number represents "row" and the second number specifies the width. 
	}

	Console.Write ("\n     ");//Used Write to introduce spacing after a newline.
	for (row = 1; row !=11; row++)//This loop draws a line under the numbers
	{
		Console.Write ("_____");
	}

	for (row = 1; row != 11; row++)//This outer loop creates the far left number that will run down the screen
	{
		Console.Write ("\n\n{0,3} |", row);// outputing two newline characters the number with width of 3 and a | character for a divider line

		for (column = 1; column != 11; column++)//This inner loop create the table
		{
			Console.Write ("{0,5}", column*row);//here we put the multiple of "column" and "row" with a width of 5
		}
	}
	Console.WriteLine("\n\nHit Enter key to quit...");
	Console.ReadLine();//keeps the screen visible until the enter key is hit.
        }
    }
}
