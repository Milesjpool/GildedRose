using GildedRose.Console.Items;
using NUnit.Framework;

namespace GildedRose.Tests.UpdateItemsTests
{
    [TestFixture]
    public class WhenIUpdateALegendaryItem
    {
        [Test]
        public void it_should_not_decrease_in_quality()
        {
            var item = new SulfurasHandOfRagnaros { Quality = 1, SellIn = 1 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(1));
        }

        [Test]
        public void it_should_not_decrease_sell_in()
        {
            var item = new SulfurasHandOfRagnaros { Quality = 1, SellIn = 1 }.UpdateItem();
            Assert.That(item.SellIn, Is.EqualTo(1));
        }
    }
}