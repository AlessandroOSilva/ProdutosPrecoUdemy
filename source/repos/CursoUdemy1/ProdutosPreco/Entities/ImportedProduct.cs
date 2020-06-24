using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutosPreco.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return (Name + " $ " + TotalPrice().ToString() + $"(Customs Fee: $ {CustomsFee})");
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string ToString()
        {
            return PriceTag().ToString();
        }

    }

}
