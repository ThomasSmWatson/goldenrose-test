using GildedRoseKata;
using System;

namespace GildedRose.ItemProcessors
{
    internal class SulfurasItemProcessor : DefaultItemProcessor
    {
        private const string _matchingStringValue = "Sulfuras, Hand of Ragnaros";

        public override void ProcessItem(Item item)
        {
            item.Quality = 80;
        }

        public override bool ConditionMatches(Item item)
        {
            return item.Name.Equals(_matchingStringValue);
        }
    }
}
