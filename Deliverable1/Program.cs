// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the restocking tool.");

int sodaStock = 100;
int chipsStock = 40;
int candyStock = 60;

int sodaRestock = 40;
int chipsRestock = 20;
int candyRestock = 40;

Console.Write("How many Sodas have been sold today? " + sodaStock + " are in stock: ");
//one step
int soda = int.Parse(Console.ReadLine());

if (soda > sodaStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted");
    
    } else
    {
        sodaStock -= soda;
        Console.WriteLine("There are " + sodaStock + " sodas left");
    }

Console.Write("How many Chips have been sold today ? " + chipsStock + " are in stock: ");
//one step
int chips = int.Parse(Console.ReadLine());

if (chips > chipsStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted");
    }
else
    {
        chipsStock -= chips;
        Console.WriteLine("There are " + chipsStock + " chips left");

}

Console.Write("How many Candy have been sold today ? " + candyStock + " are in stock: ");
//one step
int candy = int.Parse(Console.ReadLine());

if (candy > candyStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted");
    }
else
    {
        candyStock -= candy;
        Console.WriteLine("There are " + candyStock + " chips left");
    }

Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");

if (sodaStock <= sodaRestock)
    {   
        Console.WriteLine("Soda needs to be retocked");
    }
if (chipsStock <= chipsRestock)
    {
        Console.WriteLine("Chips needs to be retocked");
    }
if (candyStock <= candyRestock)
    {
        Console.WriteLine("Candy needs to be retocked");
    }

Console.WriteLine("Goodbye!");