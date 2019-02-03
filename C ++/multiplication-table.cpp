 
# include <iostream>
# include <iomanip>
// import header files to use import/export and formatting commands
using namespace std;
// reduces typing code otherwise "cout" would be typed as std::cout
int main()
//start of the code
{
int x = 0;//our first variable called x with a value of 0
int y = 0;//our second variable called y with a value of 0
char hold = 0;// This variable will store a character rather than an integer like the previous two variables.
int value = 0;
int i = 0;
cout << " Multiplication Table\n\n\n\n";//our first output to the screen
cout << " ";//outputs some black characters to the screen
for (i= 1; i != 11;i++)//This is a for loop, using a variable "i" with a value starting at 1 and keeps incrementing until it reaches 11 and finally exits the loop.
//This loop output the number 1 through 10 across the top of the screen
{
cout << setw(5) << i;//outputting the variable i to the screen with a width of 5
}
cout << "\n ";//Starts a new line on the screen following some spaces.
for (i= 1; i != 11;i++)// This loop will output the "_" character across the screen
{
cout << "_____";
}
cout << endl << endl;//endl means end line or return character which will start a new line.
for (y = 1; y != 11; ++y)//here is the meat and potatoes of the table
{
cout << setw(3) << y << "|";//output a number then the | character to give us the numbers running down the side of the screen
for (x = 1; x != 11; ++x)//this loop will output the multiplication values of the table it self, going across, then new line repeating until 10 x 10 is reached
{
value = x*y; // here we did something a bit different, we are placing the multiple of "x" and "y" into the varible "value".
cout << setw(5) << value;// and here we output the varible "value"
}
cout << " " << endl << endl;
}
cout << "\n\nPress the red X in the upper right hand corner to close window" << endl; cin >> hold;// This keep the screen open so the user can see the output.
return 0;
}
