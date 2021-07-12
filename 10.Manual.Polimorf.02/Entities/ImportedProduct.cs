using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class ImportedProduct : Product{
        public double CustomsFee { get; set; }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }

        public override string PriceTag() {
            return Name
                + " (Imported ) $ "
                + Price.ToString("F2")
                + " (Custom fee: $"
                +TotalPrice().ToString("F2")
                + ")";
        }
    }
}
