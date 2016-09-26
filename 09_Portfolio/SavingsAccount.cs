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
            //string s = string.Format("{0:0.0}", balance);
            //string stringbalance = s.Replace(',', '.');
            string stringbalance = balance.ToString("0.0", CultureInfo.InvariantCulture);

            //string i = string.Format("{0:0.0}", interestrate);
            //string irate = i.Replace(',','.');
            string irate = interestrate.ToString("0.0", CultureInfo.InvariantCulture);

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