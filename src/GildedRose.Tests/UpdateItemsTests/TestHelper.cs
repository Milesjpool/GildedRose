using System.Collections.Generic;
using GildedRose.Console;

namespace GildedRose.Tests.UpdateItemsTests
{
    public static class TestHelper
    {
        public static Item UpdateQuality(this Item item)
        {
            var program = new Program { Items = new List<Item> { item } };
            program.UpdateQuality();

            return item;
        }
    }
}
