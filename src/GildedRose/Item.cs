using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GildedRoseKata
{
    // Cannot change this because goblins with guns will one-shot me :(
    public class Item
    {
        public string Name { get; set; } // Name of the item
        public int SellIn { get; set; } // `SellIn` value which denotes the number of days we have to sell the `items`
        public int Quality { get; set; } //`Quality` value which denotes how valuable the item is
    }
 
}

