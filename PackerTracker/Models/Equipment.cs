using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class Equipment
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemMass { get; set; }
        public bool PurchaseOrNot { get; set; }
        public bool PackedOrNot { get; set; }
        public int Id { get; }
        private static List<Equipment> _instances = new List<Equipment> { };

        public Equipment(string itemName, int itemPrice, int itemMass, bool purchaseOrNot, bool packedOrNot)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemMass = itemMass;
            PurchaseOrNot = purchaseOrNot;
            PackedOrNot = packedOrNot;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static Equipment Find(int SearchId)
        {
            return _instances[SearchId - 1];
        }

        public static List<Equipment> GetAll()
        {
            return _instances;
        }

    }
}