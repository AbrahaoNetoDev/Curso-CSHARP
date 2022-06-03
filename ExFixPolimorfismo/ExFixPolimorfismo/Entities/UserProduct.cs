using System;
using System.Globalization;

namespace ExFixPolimorfismo.Entities
{
    public class UserProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UserProduct()
        {

        }

        public UserProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufature date: "
                + ManufatureDate.ToString("dd/MM/yyyy")
                + ")";
                
        }
    }
}
