using System.Collections.Generic;

namespace _09_Portfolio
{
    public class Portfolio
    {
        //Fields
        private List<IAsset> portlist = new List<IAsset>();
        //Constructors
        public Portfolio(List<IAsset> portlist)
        {
            this.portlist = portlist;
        }
        public Portfolio()
        {

        }
        //Methods
        public double GetTotalValue()
        {
            double totalvalue = 0;
            foreach (var item in portlist)
            {
                totalvalue += item.GetValue();
            }

            return totalvalue;
        }

        public void AddAsset(IAsset ass)
        {
            this.portlist.Add(ass);
        }
    }
}