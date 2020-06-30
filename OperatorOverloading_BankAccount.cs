using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming101
{
    class OperatorOverloading_BankAccount
    {
        private double money;
        private string owner;

        public OperatorOverloading_BankAccount(double money, string owner)
        {
            //this = the variable in the class - above....
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        public static OperatorOverloading_BankAccount operator +(OperatorOverloading_BankAccount Bank1, OperatorOverloading_BankAccount Bank2)
        {
            /*
             * 
             * using in main...
             * 
                OperatorOverloading_BankAccount BankAccount1 = new OperatorOverloading_BankAccount(100, "Jesse");
            OperatorOverloading_BankAccount BankAccount2 = new OperatorOverloading_BankAccount(150, "John");

            OperatorOverloading_BankAccount BankAccount3 = BankAccount1 + BankAccount2;

            Console.WriteLine(BankAccount3.Money);
            Console.WriteLine(BankAccount3.Owner);

             */
            //overloading the plus operator
            double newAmountOfMoney = Bank1.Money + Bank2.Money;
            string newOwners = Bank1.Owner + " + " + Bank2.Owner;

            OperatorOverloading_BankAccount newBankAccount = new OperatorOverloading_BankAccount(newAmountOfMoney, newOwners);
            return newBankAccount;
        }
    }
}
