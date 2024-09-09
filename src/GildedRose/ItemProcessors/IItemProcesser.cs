using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemProcessors
{
    // Item processors match Items and then have a function which will 'process' the item's business logic respectively 
    internal abstract class ItemProcessor
    {
        public virtual void ProcessItem(Item item)
        {
            {
                UpdateQuality(item);

                UpdateSellIn(item);
                if (item.SellIn < 0 && item.Quality > 0)
                {
                    UpdateQuality(item);
                }
            }
        }
        public abstract void UpdateQuality(Item item);
        public abstract void UpdateSellIn(Item item);

        public abstract bool ConditionMatches(Item item);
    }
}
