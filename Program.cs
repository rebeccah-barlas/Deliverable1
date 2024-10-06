using System.ComponentModel.Design;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome to the restocking tool");

Console.WriteLine("How many sodas have been sold today? 100 are in stock");
    int soda = int.Parse(Console.ReadLine());
    int sodastock = 100;
    int sodarestock = 40;
{
    if (soda > sodastock)
        Console.WriteLine("That value is too high. Stock not adjusted");
    else
    {
        sodastock = sodastock - soda;
        Console.WriteLine(sodastock + " sodas are left in stock");
    }
}

Console.WriteLine("How many chips have been sold today? 40 are in stock");
    int chip = int.Parse(Console.ReadLine());
    int chipstock = 40;
    int chiprestock = 20;
{
    if (chip > chipstock)
        Console.WriteLine("That value is too high. Stock not adjusted");
    else
    {
        chipstock = chipstock - chip;
        Console.WriteLine(chipstock + " chips are left in stock");
    }
}

Console.WriteLine("How many candies have been sold today? 60 are in stock");
    int candy = int.Parse(Console.ReadLine());
    int candystock = 60;
    int candyrestock = 40;
{
    if (candy > candystock)
        Console.WriteLine("That value is too high. Stock not adjusted");
    else
    {
        candystock = candystock - candy;
        Console.WriteLine(candystock + " candy are left in stock");
    }
}

Console.WriteLine("Thank you for filling out the values.");

{
    if (sodastock <= sodarestock)
    {
        Console.WriteLine("Soda needs to be restocked");
    }
    if (chipstock <= chiprestock)
    {
        Console.WriteLine("Chips needs to be restocked");
    }
    if (candystock <= candyrestock)
    {
        Console.WriteLine("Candy needs to be restocked");
    }
    if (sodastock - soda > sodarestock && chipstock - chip > chiprestock && candystock - candy > candyrestock)
    {
        Console.WriteLine("Nothing needs to be restocked");
    }
}

Console.WriteLine("Goodbye!");




