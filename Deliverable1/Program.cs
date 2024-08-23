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

//Sell Soda 
Console.WriteLine("welcome to the restocking tool.");
Console.WriteLine("How many Sodas have been sold today? 100 are in stock");
int soldSoda = int.Parse(Console.ReadLine());
int sodaRestockValue = 100 - soldSoda;
if (soldSoda <= 100) { 
    Console.WriteLine("There are " + sodaRestockValue + " sodas left.");
} else { 
 Console.WriteLine("That value is too high. Stock not adjusted.");
 }

//Sell Chips 
Console.WriteLine("How many Chips have been sold today? 40 are in stock");
int soldChips = int.Parse(Console.ReadLine());
int chipsRestockValue = 40 - soldChips;
if (soldChips <= 40)
{
    Console.WriteLine("There are " + chipsRestockValue + " chips left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}

//Sell Candy 
Console.WriteLine("How much much candy has been sold today? 60 are in stock");
int soldCandy = int.Parse(Console.ReadLine());
int CandyRestockValue = 60 - soldCandy;
if (soldCandy <= 60)
{
    Console.WriteLine("There are " + CandyRestockValue + " Candies left.");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}


if (soldSoda >= 60 && soldSoda<= 100)
{
    Console.WriteLine("Sodas need to be restocked!");
}

if (soldChips >= 20 && soldChips <= 40)
{
    Console.WriteLine("Chips need to be restocked!");
}

if (soldCandy >= 20 && soldCandy <= 60)
{
    Console.WriteLine("Candies need to be restocked!");
}
