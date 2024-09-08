using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        //   We have recently signed a supplier of conjured items.This requires an update to our system:
        //- __"Conjured"__ items degrade in `Quality` twice as fast as normal items


        //Feel free to make any changes to the `UpdateQuality` method and add any new code as long as everything
        //still works correctly.However, do not alter the `Item` class or `Items` property as those belong to the
        //goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code
        //ownership(you can make the `UpdateQuality` method and `Items` property static if you like, we'll cover
        //for you).

        //Just for clarification, an item can never have its `Quality` increase above `50`, however __"Sulfuras"__ is a
        //legendary item and as such its `Quality` is `80` and it never alters.
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];

                switch (item.Name)
                {
                    case "Aged Brie":
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        item.SellIn = item.SellIn - 1;

                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
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
                        item.SellIn = item.SellIn - 1;
                        if (item.SellIn < 0)
                        {
                            item.Quality = 0;
                        }

                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    default:
                        if (item.Quality > 0)
                        {
                             item.Quality = item.Quality - 1;
                        }
                        item.SellIn = item.SellIn - 1;
                        break;
                }



                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }

    }
}
