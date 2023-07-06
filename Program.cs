// See https://aka.ms/new-console-template for more information
// Change the appearance

Console.Title = "e";
Console.ForegroundColor = ConsoleColor.Green;
Console.WindowHeight = 40;

// Get a conversation going

Console.WriteLine("hi");

Console.ReadLine(); // This works too

Console.WriteLine("gfds. \nasasasasasasa");
Console.WriteLine("resxfsdsds");

Console.ReadLine();

Console.WriteLine("Cvvvvvvvvvvv");

Console.WriteLine("What's your name?");

string userName = Console.ReadLine();

Console.WriteLine("Hello! " + userName + ", nice to meet you!");

double num01;
double num02;

Console.Write("Input a number: ");

num01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input a second number: ");

num02 = Convert.ToDouble( Console.ReadLine() );

double result1 = num01 / num02;
Console.WriteLine("The result is " + result1);

// Conditions

Console.WriteLine("Welcome! Tickets are $5. Please insert cash.");

int cash = Convert.ToInt32( Console.ReadLine() );

if (cash < 5)
{
   Console.WriteLine("thats not enough money");
}
else if (cash == 5)
{
    Console.WriteLine("here is your ticket.");
}
else
{
    int change = cash - 5;
    Console.WriteLine("here is your ticket and " + change + " dollars in change.");
}


// repeating

Console.Write("how any cool numers do you want: ");

int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    double result2 = Math.Pow(2, i);
    Console.WriteLine(result2);
    
}


Random numberGen = new Random();

int roll =0;
int attempts =0;

Console.WriteLine("pess enter to roll the die.");

while(roll !=5) {
Console.ReadKey();

roll = numberGen.Next(1, 11);
Console.WriteLine("you rolled: " + roll);
attempts++;
}

Console.WriteLine("it took you " + attempts + " attempts to roll a five.");
if (attempts == 1)
{
    Console.WriteLine("nice first try");
}


string[] movies1 = {"lord of the rings", "fight club", "intersteller", "gladiator"};

for (int i = 0; i < movies1.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine(rank + ". " + movies1[i] );
}


string[] movies2 = new string[4];

Console.WriteLine("type in four movies: ");

for (int i = 0; i < movies2.Length; i++)
{
movies2[i] = Console.ReadLine();
}


Console.WriteLine("\nhere the are alphabetically: ");

Array.Sort(movies2);

for (int i = 0; i < movies2.Length; i++)
{
    Console.WriteLine(movies2[i]);
}


List<string> shoppingList = new List<string>();

shoppingList.Add("Drinks");
shoppingList.Add("Food");
shoppingList.Add("Sweets");
shoppingList.Add("Chips");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Chips");
shoppingList.RemoveAt(1);

Console.WriteLine("-----------------");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}


MeetAlien();

// Wait before closing
Console.ReadKey();


static void MeetAlien()
{
Random numberGen = new Random();

string name = "x-" + numberGen.Next(10, 9999);
int age = numberGen.Next(10, 500);

Console.WriteLine("hi, im " + name);
Console.WriteLine("im " + age + " years old.");
Console.WriteLine("oh, and im an alien.");
}






int result3 = Multiply(3, 5);

Console.WriteLine("the result is " + result3);

if (result3 % 2 == 0)
{
Console.WriteLine(result3 + " is an even number!");
} else
{
Console.WriteLine(result3 + " is an uneven number!");
}

// Wait before closing
Console.ReadKey();

static int Multiply (int num01, int num02)
{
int result3 = num01 * num02;
return result3;
}


Wizard wizard01 = new Wizard("Benedikt", "penis errectus");


wizard01.CastSpell();
wizard01.CastSpell();
wizard01.CastSpell();

wizard01.Meditate();
wizard01.CastSpell();
wizard01.CastSpell();


Console.WriteLine("experience: " + wizard01.experience);

// Wait before closing
Console.ReadKey();

class Wizard
{
    public string name;
    public string favoriteSpell;
    public int spellSlots;
    public float experience;

    public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
        
            spellSlots = 2;
            experience = 0f;
        }
    

    public void CastSpell()
    {
        if (spellSlots > 0)
        {
        Console.WriteLine(name + " casts " + favoriteSpell);
        spellSlots--;
        experience += 0.3f;
        } else
        {
            Console.WriteLine(name + " is out of spell slots.");
        }
        
    }   
    public void Meditate()
    {
    Console.WriteLine(name + " meditate to regain spell slots.");
    spellSlots += 2;
    }
}   