using System.Collections.Generic;

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

            app.UpdateQuality();

            System.Console.ReadKey();
        }

	    public void UpdateQuality()
	    {
	        foreach (Item item in Items)
	        {
	            if (item.Name == "Aged Brie" || item.Name == "Backstage passes to a TAFKAL80ETC concert")
	            {
	                if (item.Quality < 50)
	                {
	                    item.Quality = item.Quality + 1;

	                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
	                    {
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
	                }
	            }
	            else
	            {
	                if (item.Quality > 0)
	                {
	                    if (item.Name != "Sulfuras, Hand of Ragnaros")
	                    {
	                        item.Quality = item.Quality - 1;
	                    }
	                }
	            }

	            if (item.Name != "Sulfuras, Hand of Ragnaros")
	            {
	                item.SellIn = item.SellIn - 1;
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
	                    else
	                    {
	                        item.Quality = item.Quality - item.Quality;
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
