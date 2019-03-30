using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssignment
{
    class Account
    {
        private int accId;

        public int AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        private int accNo;

        public int AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { if (value > 0) balance = value; }
        }

    

        public Account(int accNo, double balance)
        {
            this.accNo = accNo;
            this.balance = balance;

        }



    }
}
