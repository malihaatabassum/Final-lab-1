using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class OverDraft
    {
        private double WithdrawMoney;

        public double WithdrawMoney
        {
            get { return withdrawMoney; }
            set { withdrawMoney = value; }
        }
        public Overdraft() { }
        public Overdraft(string acNo, string acNm, double bal, double withdrwmoney) : base(acNo, acNm, bal)
        {
           
        }


        public override void Deposit(double amount)
        {

            if (bal + amount > 0)
            {
                bal += amount;
            }


        }

        public override void Withdraw(double amount)
        {
            if (bal- amount < withdrawMoney)
            {
                bal -=  amount;
            }
            else
            {
                Console.WriteLine("No Balance");
            }
        }
       
        public override void ShowInfo()
        {
            base.ShowInfo();

        }
    }
}
    }
}
