using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.ItemProcessors
{
    // Item processors match Items and then have a function which will 'process' the item's business logic respectively 
    internal interface IItemProcessor
    {
        Func<Item,bool> ConditionMatches { get; }
        public void ProcessItem(Item item);
    }
}
