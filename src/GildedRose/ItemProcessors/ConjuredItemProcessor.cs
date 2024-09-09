using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemProcessors
{
    internal class ConjuredItemProcessor : DefaultItemProcessor
    {

        public override void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }

            if (item.Quality < 0) item.Quality = 0;
        }
        public override bool ConditionMatches(Item item)
        {
            return item.Name.Contains("Conjured");
        }
    }
}
