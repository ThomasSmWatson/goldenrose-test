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
    internal class BrieItemProcessor : IItemProcessor
    {
        private const string _matchingStringValue = "Aged Brie";
        public bool MatchesCondition(Item item)
        {
            return item.Name.Equals(_matchingStringValue);
        }

        public void ProcessItem(Item item)
        {
            if(item.SellIn == 0){
                item.SellIn = item.SellIn - 2;
            }
            else{
                item.SellIn = item.SellIn -1;
            }
                
            if(item.SellIn<50) ++item.Quality;

        }
    }
}
