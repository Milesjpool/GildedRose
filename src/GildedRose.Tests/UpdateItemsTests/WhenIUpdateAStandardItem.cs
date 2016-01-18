using GildedRose.Console.Items;
using NUnit.Framework;

namespace GildedRose.Tests.UpdateItemsTests
{
    [TestFixture]
    public class WhenIUpdateAStandardItem
    {

        [Test]
        public void it_should_decrement_sell_in()
        {
            var item = new StandardItem {SellIn = 1, Quality = 1 }.UpdateItem();
            Assert.That(item.SellIn, Is.EqualTo(0));
        }

        [Test]
        public void it_should_decrement_quality()
        {
            var item = new StandardItem { SellIn = 1, Quality = 1 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(0));
        }

        [Test]
        public void when_the_sell_in_has_passed_it_should_decrement_quality_twice_as_fast()
        {
            var item = new StandardItem {  SellIn = 0, Quality = 2 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(0));
        }

        [Test]
        public void quality_should_never_be_negative()
        {
            var item = new StandardItem { SellIn = 1, Quality = 0 }.UpdateItem();
            Assert.That(item.Quality, Is.EqualTo(0));
        }
    }

    public class StandardItem : Item
    {
        public string Name
        {
            get { return "standard item"; }
        }
    }
}