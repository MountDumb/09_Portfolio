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
            for (int i = 0; i < portlist.Count; i++)
            {
                totalvalue += portlist[i].GetValue();
            }

            return totalvalue;
        }

        //gone due to refactoring.
        //public static double TotalValue(List<IAsset> assets)
        //{
        //    return new Portfolio(assets).GetTotalValue();

        //}

        public void AddAsset(IAsset ass)
        {
            this.portlist.Add(ass);
        }
    }
}