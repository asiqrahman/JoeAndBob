using System;
namespace JoeAndBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter the amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who Should give the cash?");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.Receivecash(cashGiven);
                    }
                    if(whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.Receivecash(amount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enetr an amount (or a blank line to exit).");
                }
            }
        }
    }
}