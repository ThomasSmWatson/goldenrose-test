using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemProcessors
{
    internal class DefaultItemProcessor : ItemProcessor
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }

        public override void UpdateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }

        public override bool ConditionMatches(Item item)
        {
            return false; // this doe snot match by default
        }
    }
}
