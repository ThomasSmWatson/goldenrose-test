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
        List<IItemProcessor> processors = new List<IItemProcessor>() { 
            new BrieItemProcessor(),
            new BackstagePassItemProcessor(),
            new SulfurasItemProcessor(),
        };
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            var defaultProcessor = new DefaultItemProcessor();
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                var processor = processors.Find(P => P.ConditionMatches != null && P.ConditionMatches(item));
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
