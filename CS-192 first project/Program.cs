// See https://aka.ms/new-console-template for more information
Console.WriteLine("I am the leader of this new world!");
Console.ReadKey();
Console.Write("Tell what is your name soldier?: ");
string name;
name = Console.ReadLine();
Console.WriteLine($"Ah your name is, {name} ,that is a fine name for a warrior!");

Console.WriteLine($"How old are you", name);
double number;
number = Convert.ToDouble(Console.ReadLine());
Console.Write(number);
if (number >= 18)
{
    Console.Write(" ,That is a fine age for a warrior to fight");
}
else
{
    Console.WriteLine(" You are too young to be a warior,but I like your spirit ");
    Console.Write($"Come back to me in { 18 - number} ");
    Console.Write("years and we'll see how much you've grown");
}