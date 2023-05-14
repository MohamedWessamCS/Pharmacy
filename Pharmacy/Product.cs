using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal abstract class Product
    {
        private string name;
        private int quantity;
        private string description;
        private float sellPrice;
        private float purchasePrice;
        public Product(string name, int quantity, string description, float sellPrice, float purchasePrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.description = description;
            this.sellPrice = sellPrice;
            this.purchasePrice = purchasePrice;
        }
        public float PurchasePrice
        {
            set
            {
                if (value > 0)
                {
                    purchasePrice = value;
                }
                else
                {
                    purchasePrice = 10f;
                }
            }
            get { return purchasePrice; }
        }
        public abstract float ReturnTotalCost();
    }
    class Local_Medication : Product
    {
        public Local_Medication(string name, int quantity, string description, int sellPrice, int purchasePrice) : base(name, quantity, description, sellPrice, purchasePrice)
        {

        }
        public override float ReturnTotalCost()
        {
            return PurchasePrice * 0.05f;
        }
    }
    class Imported_Medication : Product
    {
        public Imported_Medication(string name, int quantity, string description, int sellPrice, int purchasePrice) : base(name, quantity, description, sellPrice, purchasePrice)
        {

        }
        public override float ReturnTotalCost()
        {
            return PurchasePrice * 0.25f;
        }
    }
}
