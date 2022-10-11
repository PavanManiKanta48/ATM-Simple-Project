using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceImplementedClass obj=new InterfaceImplementedClass();
            // Create a list of CardHolders.
            List<CardHolder> cardHolders = new List<CardHolder>();
            // Add CardHolders details to the list.
            cardHolders.Add(new CardHolder("1234567890123456", 1234, "Pavan", "Kolli", 140.32));
            cardHolders.Add(new CardHolder("1234567890234567", 2345, "Tarun", "Kottiboina", 340.32));
            cardHolders.Add(new CardHolder("1234567890345678", 3456, "Charan", "Patil", 540.32));
            cardHolders.Add(new CardHolder("1234567890456789", 4567, "Balu", "Areti", 230.32));
            cardHolders.Add(new CardHolder("1234567890567890", 5678, "Praveen", "Kopparthi", 140.32));

           
            void withdrawn(CardHolder currentUser1)
            {
                Console.WriteLine("How much Money would u like to withdrawn:");
                double withdrawal = Double.Parse(Console.ReadLine());
                //CHECK IF THE USER HAS ENOUGH MONEY OR NOT
                if (currentUser1.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient Balance Don't roam around ATM:");
                }
                else
                {
                    currentUser1.setBalance(currentUser1.getBalance() - withdrawal);
                    Console.WriteLine("You're good to go! Thank You :)");
                }
            }
           
            
            //Prompt User
            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please insert your debit card : ");
            string debitCardNum = "";
            CardHolder currentUser;
            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    //check against our db
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);    //It will cycle through list of cardholder.
                    if (currentUser != null) { break; }                                           
                    else
                    {
                        Console.WriteLine("Card not recognized. please try again");
                    }
                }
                catch
                { Console.WriteLine("card not recognized. please try again"); }
            }
                Console.WriteLine("Please enter your Pin :");
                int userPin = 0;
                while (true)
                {
                    try
                    {
                        userPin = int.Parse(Console.ReadLine());
                        if (currentUser.getPin() == userPin) { break; }
                        else { Console.WriteLine("Incorrect pin please try again."); }
                    }
                    catch  
                    { Console.WriteLine("Card not recognized . Please try again");   }
                }
                Console.WriteLine("Welcome "+currentUser.getFirstName()+ " :)");
                int option = 0;
                do
                {
                    obj.printOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch { }
                    if (option == 1) { obj.deposit(currentUser); }
                    else if (option == 2) { withdrawn(currentUser); }
                    else if (option == 3) { balance(currentUser); }
                    else if (option == 4) { break; }
                    else { option = 0; }
                }
                while (option != 4);
            
        }
    }
}
