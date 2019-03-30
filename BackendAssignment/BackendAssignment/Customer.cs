using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssignment
{
    class Customer
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int customerNo;

        public int CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        private Account account;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public Customer(int customerNo, string firstName, string lastName, string address, Account account)
        {
            this.customerNo = customerNo;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.account = account;
        }


        public void GetAccountBalance()
        {
         
            Console.WriteLine(account.Balance);

        }

        //below - remainings of the alternative solution

        //public bool Withdraw(double amount)
        //{
        //    bool ok = false;

        //    if (account.Balance >= amount && amount >= 0)
        //    {
        //        account.Balance = account.Balance - amount;
        //        ok = true;
        //    }
        //    if (!ok)
        //    {
        //        Console.WriteLine("You do not have enough money. Check if the amount you want to withdraw is correct.");
        //    }
        //    return ok; 
        //}

        //public bool Deposit(double amount)
        //{
        //    bool ok = false;
        //    if (amount > 0)
        //    {
        //        account.Balance = account.Balance + amount;
        //        ok = true;
        //    }

        //    if (!ok)
        //    {
        //        Console.WriteLine("The amount has to be higher");
        //    }
        //    return ok;
        //}



    }
}
