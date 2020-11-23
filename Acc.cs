using System;
using System.Collections.Generic;
using System.Text;

namespace oopf
{
    abstract class Acc
    {
        private string acNo;

        public string AcNo
        {
            get { return acNo; }
            set { acNo = value; }
        }
        private string acNm;

        public string AcNm
        {
            get { return acNm; }
            set { acNm = value; }
        }
        protected double bal;

        public double Bal
        {
            get { return bal; }
            set { bal = value; }
        }
        public Acc()
        {

        }
        public Acc(string acNo, string acNm, double bal)
        {
            this.acNo = acNo;
            this.acNm = acNm;
            this.bal = bal;
        }

        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accNo);
            Console.WriteLine("Balance: " + balance);
        }
    }
}