using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutosPreco.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return (Name + "(used)" + " $ " + Price + $"(Manufacture date : {ManufactureDate}");
        }

        public override string ToString()
        {
            return PriceTag().ToString();
        }
    }
}
