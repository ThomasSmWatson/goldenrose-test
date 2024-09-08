using GildedRoseKata;
using System;

namespace GildedRose.ItemProcessors
{
    internal class SulfurasItemProcessor : IItemProcessor
    {
        private const string _matchingStringValue = "Sulfuras, Hand of Ragnaros";
        public Func<Item, bool> ConditionMatches => new Func<Item, bool>((Item item) => { return item.Name.Equals(_matchingStringValue); });

        public void ProcessItem(Item item)
        {
            item.Quality = 80;
        }
    }
}
