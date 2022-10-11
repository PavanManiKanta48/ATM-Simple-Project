using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class CardHolder
    {
        public string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public CardHolder(string cardNum, int pin, string firstName, string lastName, Double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
        public string getNum()
        {
            return cardNum;
        }
        public int getPin()
        {
            return pin;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public Double getBalance()
        {
            return balance;
        }
        public void setNum(string newCardNumber)
        {
            cardNum = newCardNumber;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLasttName(string newLastName)
        {
            lastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

    }
}
