// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the restocking tool.");
Console.WriteLine("");
int stockSoda = 100;
int restockSoda = 40;
Console.WriteLine("How many Sodas have been sold today? " + stockSoda + " are in stock");
int sodaInput = Int32.Parse(Console.ReadLine());
int sodaLeft = stockSoda - sodaInput;
if (sodaLeft >= 0)
{
    Console.WriteLine("There are " + sodaLeft + " Sodas left");
} else
{
    Console.WriteLine("That value is too high. Stock is not adjusted");
}
Console.WriteLine("");
int stockChips = 40;
int restockChips = 20;
Console.WriteLine("How many Chips have been sold today? " + stockChips + " are in stock");
int chipsInput = Int32.Parse(Console.ReadLine());
int chipsLeft = stockChips - chipsInput;
if (chipsLeft >= 0)
{
    Console.WriteLine("There are " + chipsLeft + " Chips left");
}
else
{
    Console.WriteLine("That value is too high. Stock is not adjusted");
}
Console.WriteLine("");
int stockCandy = 60;
int restockCandy = 40;
Console.WriteLine("How many Candy have been sold today? " + stockCandy + " are in stock");
int candyInput = Int32.Parse(Console.ReadLine());
int candyLeft = stockCandy - candyInput;
if (candyLeft >= 0)
{
    Console.WriteLine("There are " + candyLeft + " Candy left");
}
else
{
    Console.WriteLine("That value is too high. Stock is not adjusted");
}
Console.WriteLine("");
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
if (sodaLeft <= restockSoda 
    && sodaInput <= stockSoda)
{
    Console.WriteLine("Soda needs to be restocked");
}
if (chipsLeft <= restockChips 
    && chipsInput <= stockChips)
{
    Console.WriteLine("Chips needs to be restocked");
}
if (candyLeft <= restockCandy
    && candyInput <= stockCandy)
{
    Console.WriteLine("Candy needs to be restocked");
}
Console.WriteLine("");
Console.WriteLine("Goodbye!");