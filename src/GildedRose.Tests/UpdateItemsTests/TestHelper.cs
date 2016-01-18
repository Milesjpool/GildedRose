using System.Collections.Generic;
using GildedRose.Console;
using GildedRose.Console.Items;

namespace GildedRose.Tests.UpdateItemsTests
{
    public static class TestHelper
    {
        public static Item UpdateItem(this Item item)
        {
            var program = new Program { Items = new List<Item> { item } };
            program.UpdateItem();

            return item;
        }
    }
}
