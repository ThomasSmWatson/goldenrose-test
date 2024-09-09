using GildedRose.ItemProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        List<ItemProcessor> processors = new List<ItemProcessor>() { 
            new BrieItemProcessor(),
            new BackstagePassItemProcessor(),
            new SulfurasItemProcessor(),
            new ConjuredItemProcessor()
        };
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var defaultProcessor = new DefaultItemProcessor();
            
            foreach (var item in Items)
            {
                var processor = processors.Find(processor => processor.ConditionMatches(item));

                if (processor != null)
                {
                    processor.ProcessItem(item);
                }
                else
                {
                    defaultProcessor.ProcessItem(item);
                }
            }
        }
    }
}
