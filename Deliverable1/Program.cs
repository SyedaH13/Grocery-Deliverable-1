// See https://aka.ms/new-console-template for more information
/*Soda starts with 100 in stock and will need a restock at 40
Chips starts with 40 in stock and will need a restock at 20
Candy starts with 60 in stock and will need a restock at 40
Each item should have a variable that holds its current stock value and a
variable that holds the restock value.

  Welcome to the restocking tool.

How many Sodas have been sold today? 100 are in stock - Ask the user this, expect a num answer and parse the input 
> 50 - You can now calculate the remaining stock of Soda. If the user enters a number higher than is in 
that item’s stock, tell the user that is “Too high” and don’t adjust the stock. Print out the remaining stock.
There are 50 Sodas left 

How many Chips have been sold today? 40 are in stock
> 30
There are 10 Chips left

How many Candy have been sold today? 60 are in stock
> 90
That value is too high. Stock not adjusted


Thank you for filling out the values. Here’s what needs to be restocked.
figure out whether each item needs a restock.  If the remaining stock is less than or equal to the restock value
print out which item needs to be restocked. 
Chips needs to be restocked

Goodbye!
 */


Console.WriteLine("welcome to the restocking tool.");

//Sell Soda 
int sodaStock = 100;
int sodaRestock = 40;

Console.WriteLine("How many Sodas have been sold today? " + sodaStock + " are in stock");
int soldSoda = int.Parse(Console.ReadLine());

if (soldSoda > sodaStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    sodaStock -= soldSoda;
    Console.WriteLine("There are " + sodaStock + " sodas left.");
}


//Sell Chips 
int chipsStock = 40;
int chipsRestock = 20;

Console.WriteLine("How many Chips have been sold today? " + chipsStock + " are in stock");
int soldChips = int.Parse(Console.ReadLine());

if (soldChips > chipsStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    chipsStock -= soldChips;
    Console.WriteLine("There are " + chipsStock + " chips left.");
}

//Sell Candy 
int candyStock = 60;
int candyRestock = 40;

Console.WriteLine("How much much candy has been sold today? " + candyStock + " are in stock");
int soldCandy = int.Parse(Console.ReadLine());
if (soldCandy > candyStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    candyStock -= soldCandy;
    Console.WriteLine("There are " + candyStock + " Candies left.");
}


if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Sodas need to be restocked!");
}

if (chipsStock <= chipsRestock)
{
    Console.WriteLine("Chips need to be restocked!");
}

if (candyStock <= candyRestock)
{
    Console.WriteLine("Candies need to be restocked!");
}
