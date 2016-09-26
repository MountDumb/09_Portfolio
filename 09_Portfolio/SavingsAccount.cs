using System.Globalization;

namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {
        //Fields
        private string accountname;
        private double interestrate;
        private double balance;

        //Constructor
        public SavingsAccount(string accountname, double balance, double interestrate)
        {
            this.accountname = accountname;
            this.balance = balance;
            this.interestrate = interestrate;
        }
        //Methods
        public double GetValue()
        {
            return balance;
        }

        public override string ToString()
        {
            //"SavingsAccount[value=1000.0,interestRate=4.2]"
            string s = string.Format("{0:0.0}", balance);
            string stringbalance = s.Replace(',', '.');

            string i = string.Format("{0:0.0}", interestrate);
            string irate = i.Replace(',','.');

            return "SavingsAccount[value=" 
                + stringbalance + ",interestRate=" + irate + "]";
        }

        public double ApplyInterest()
        {
            balance += balance * interestrate / 100;
            return balance;
        }
        //Properties

        public double InterestRate
        {
            get { return this.interestrate; }
            set { this.interestrate = value; }
        }

    }
}