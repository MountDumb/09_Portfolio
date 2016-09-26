using System.Globalization;

namespace _09_Portfolio
{
    public class Stock : IAsset
    {
        //Fields
        private string symbol;
        private double pricepershare;
        private int numshares;

        //Constructors
        public Stock(string symbol, double pricepershare, int numshares)
        {
            this.symbol = symbol;
            this.pricepershare = pricepershare;
            this.numshares = numshares;
        }
        public Stock()
        {

        }

        //Methods
        public double GetValue()
        {
            return pricepershare * numshares;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double sumvalue = 0;
            foreach (IAsset stock in stocks)
            {
                sumvalue += stock.GetValue();
            }
            return sumvalue;

        }

        public override string ToString()
        {
            //"Stock[symbol=ABC,pricePerShare=12.23,numShares=50]"
            string ppsstring = pricepershare.ToString(CultureInfo.InvariantCulture);

            return "Stock[symbol=" + this.symbol + ",pricePerShare="
                + ppsstring + ",numShares=" + this.numshares + "]";
        }

        public override bool Equals(object obj)
        {
            Stock s = (Stock)obj;
            if (this.symbol == s.Symbol && this.pricepershare == s.PricePerShare 
                && this.numshares == s.NumShares)
            { return true; }
            else
            { return false; }
        }

        //Properties

        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public double PricePerShare
        {
            get { return this.pricepershare; }
            set { this.pricepershare = value; }
        }

        public int NumShares
        {
            get { return this.numshares; }
            set { this.numshares = value; }
        }
    }
}