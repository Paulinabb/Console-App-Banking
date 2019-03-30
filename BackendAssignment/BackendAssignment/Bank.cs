using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssignment
{
    class Bank
    {
        public Bank(string bankName, int bankId)
        {
            this.bankName = bankName;
            this.bankId = bankId;
            this.customer = new List<Customer>();
        }

        private int bankId;

        public int BankId
        {
            get { return bankId; }
            set { bankId = value; }
        }

        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        private List<Customer> customer;

        public List<Customer> Customer
        {
            get { return customer; }
            set { customer = value; }
        }


        public void AddCustomer(Customer c)
        {
            customer.Add(c);
            Console.WriteLine("New customer has been added");
        }


        public void FindCustomer(int cuNo)
        {

            bool found = false;                                 //setting false bool variable
            foreach (Customer cust in customer)                //running trough each element in the customer list
            {
                if (cust.CustomerNo == cuNo)                 //when the parameter equals to one of the customer's number then...
                {
                    Console.WriteLine(cust.CustomerNo + ", First name: " + cust.FirstName + ", Last name: " + cust.LastName + ", Balance: " + cust.Account.Balance + ", Address: " + cust.Address);
                    found = true;                         //set to true, because operation was successfull
                    break;                               //break out of the loop, finish operation
                }
            } 

            if (!found)                                //if bool variable is still set to false (operation did not go well) then...
            {
                Console.WriteLine("Could not find the customer. Check if the number was correct and try again!"); 
            }
        }




        public void RemoveCustomer(int cNo, int aNo)
        {
            bool found = false;
            foreach (Customer cust in customer)
            {
                if (cust.CustomerNo == cNo && cust.Account.AccNo == aNo)
                {
                    customer.Remove(cust);
                    Console.WriteLine("The customer has been deleted.");
                    found = true;
                    break;
                }
            }

            if (!found)
                {
                    Console.WriteLine("Could not find the customer. Check if the number was correct and try again.");
                }
        }



        public void TransferMoney(int cNo1, int cNo2, double amount)
        {
                bool found = false;
 
                foreach (Customer cust in customer)
                foreach (Customer cust2 in customer)
                {
                    if (cust.CustomerNo == cNo1 && cust2.CustomerNo == cNo2 && cust.Account.Balance >= amount && amount > 0)   //if customers ids match and balance is not lower that the amount and amount is not smaller than 0, then...
                    {
                        //below - remainings of the alternative solution
                        //cust.Withdraw(amount); 
                        //cust2.Deposit(amount);

                        cust.Account.Balance = cust.Account.Balance - amount;
                        cust2.Account.Balance = cust2.Account.Balance + amount;
                        found = true;
                        break;
                    }
                }

            if (!found)

                    {
                        Console.WriteLine("Check if the customer with that number exist or has enough money on their account");
                    }
        }


        public void UpdateAddress(int cNo, string address)
        {
            bool found = false;
            foreach (Customer cust in customer)
            {
                if (cust.CustomerNo == cNo)
                {
                    cust.Address = address;    //set address of that customer to the address (string) that was input
                    Console.WriteLine("Address of the following customer was updated: " + cust.CustomerNo + ", First name: " + cust.FirstName + ", Last name: " + cust.LastName + ", Address: " + cust.Address);
                    found = true;
                    break;
                }
            }

            if (!found)

                {
                    Console.WriteLine("Could not find the customer. Try again.");
                }
        }

    }
}


    

