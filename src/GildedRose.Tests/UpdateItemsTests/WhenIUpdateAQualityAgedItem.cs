using GildedRose.Console;
using GildedRose.Console.Items;
using NUnit.Framework;

namespace GildedRose.Tests.UpdateItemsTests
{
    [TestFixture]
    public class WhenIUpdateAQualityAgedItem
    {
        [Test]
        public void it_should_increase_in_quality()
        {
            var item = new AgedBrie { Quality = 1, SellIn = 1 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(2));
        }

        [Test]
        public void quality_should_never_increase_beyond_fifty()
        {
            var item = new AgedBrie { Quality = 50, SellIn = 1 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(50));
        }

        [Test]
        public void sell_in_should_still_decrement_normally()
        {
            var item = new AgedBrie { Quality = 1, SellIn = 1 }.UpdateItem();
            Assert.That(item.SellIn, Is.EqualTo(0));
        }

        [Test]
        public void quality_doubles_once_sell_in_is_zero()
        {
            var item = new AgedBrie { Quality = 1, SellIn = 0 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(3));
        }
    }
}