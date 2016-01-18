using System.Collections.Generic;
using GildedRose.Console.Items;

namespace GildedRose.Console
{
	public class Program
    {
		public IList<Item> Items;
        static void Main()
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program
                {
                              Items = new List<Item>
                                          {
                                              new Plus5DexterityVest {SellIn = 10, Quality = 20},
                                              new AgedBrie {SellIn = 2, Quality = 0},
                                              new ElixirOfTheMongoose {SellIn = 5, Quality = 7},
                                              new SulfurasHandOfRagnaros {SellIn = 0, Quality = 80},
                                              new BackstagePassesToATAFKAL80ETCConcert {SellIn = 15,Quality = 20},
                                              new ConjuredManaCake {SellIn = 3, Quality = 6}
                                          }

                          };

            app.UpdateItem();

            System.Console.ReadKey();
        }

	    public void UpdateItem()
	    {
	        foreach (var item in Items)
	        {
                item.UpdateQuality();
                item.UpdateSellIn();
	        }
	    }
    }
}
