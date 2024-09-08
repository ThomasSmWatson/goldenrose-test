using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemProcessors
{
    internal class ConjuredItemProcessor : IItemProcessor
    {
        public Func<Item, bool> ConditionMatches => new Func<Item, bool>((Item item) => item.Name.Contains("Conjured"));

        public void ProcessItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }

            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
                if (item.Quality < 0) item.Quality = 0;
            }
        }
    }
}
