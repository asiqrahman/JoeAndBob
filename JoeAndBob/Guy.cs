using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAndBob
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        ///<summary>
        ///writes the name and the amount of cash have to console. 
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks. ");
        }
        ///<summary>
        ///Gives some of my cash, removing it from my wallet ( or printing
        /// a massage to the console if I don't have enough cash).
        /// </summary>
        /// <parm name="amount">Amount of cash to give.</parm>
        /// <returns>
        /// the amount of cash removed from my wallet, or ) if I don't
        /// have enough cash(or if the amount is invalid).
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <=  0)
            {
                Console.WriteLine(Name + " says " + amount + " is not a valid amount. ");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says " + " I don't have enough amount to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Receive some cash, adding it to my wallet (or printing
        /// a message to the console if the amount is invalid).
        /// </summary>
        /// <param name="amount">Amount of cash to receive.</param>
        public void Receivecash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says " + amount + "isn't an amount I'll take ");

            }
            Cash += amount;
        }
    }
}
