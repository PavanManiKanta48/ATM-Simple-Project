using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
     class InterfaceImplementedClass:Interface1
    {
        public void printOptions()
        {
            Console.WriteLine("Please choose from One of the following option");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. WithDrawn");
            Console.WriteLine("3. Show  Balance");
            Console.WriteLine("4. Exit");
        }
        public void deposit(CardHolder currentUser1)
        {
            Console.WriteLine("How much money $$ would you like to deposit :");
            double deposit1 = Double.Parse(Console.ReadLine());
            currentUser1.setBalance(currentUser1.getBalance() + deposit1);
            Console.WriteLine("Thanks for your $$. YOur new balance is :" + currentUser1.getBalance());
        }
       public void balance(CardHolder currentUser1)
        {
            Console.WriteLine("Current balance: " + currentUser1.getBalance());
        }
    }
}
