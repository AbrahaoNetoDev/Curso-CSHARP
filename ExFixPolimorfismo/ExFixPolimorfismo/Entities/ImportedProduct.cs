using System;
using System.Globalization;

namespace ExFixPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double Customsfee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            Customsfee = customsfee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                +"(Custom fee: $ "
                + Customsfee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
