using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





// CORE FUNCTIONALITY
//	- `Quality` increases by `2` when there are `10` days or less and by `3` when there are `5` days or less but
//- Once the sell by date has passed, `Quality` degrades twice as fast
//- The `Quality` of an item is never negative

//- __"Aged Brie"__ actually increases in `Quality` the older it gets
//- The `Quality` of an item is never more than `50`


namespace GildedRose.ItemProcessors
{
    internal class BackstagePassItemProcessor : DefaultItemProcessor
    {
        private const string _matchingStringValue = "Backstage passes to a TAFKAL80ETC concert";

        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        public override bool ConditionMatches(Item item)
        {
            return item.Name.Equals(_matchingStringValue);
        }
    }
}
