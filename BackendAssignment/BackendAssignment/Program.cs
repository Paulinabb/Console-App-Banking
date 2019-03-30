using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank myBank = new Bank("My bank", 100);
            Account acc1 = new Account(01, 100);
            Customer cust1 = new Customer(1, "Paulina", "Bakalarz", "6 Dywizji Piechoty 2/6, Kolobrzeg, Poland", acc1);

            Account acc2 = new Account(02, 100);
            Customer cust2 = new Customer(2, "John", "Doe", "445 Mount Eden Road, Mount Eden, Auckland", acc2);

            myBank.AddCustomer(cust1);
            myBank.AddCustomer(cust2);

            cust1.GetAccountBalance();
            cust2.GetAccountBalance();

            myBank.FindCustomer(1);
            

            myBank.TransferMoney(1, 2, 10);
         

            cust1.GetAccountBalance();
            cust2.GetAccountBalance();

            

            myBank.UpdateAddress(2, "New addres 2/8");


            
            myBank.RemoveCustomer(1, 01);



            

            //myBank.UpdateAddress(5, "New addres 2/8");
            //myBank.FindCustomer(0);
            //cust1.Withdraw(0);
            //cust1.GetAccountBalance();


        }



    }
}
