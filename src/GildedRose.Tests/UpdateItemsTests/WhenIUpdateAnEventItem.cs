using GildedRose.Console.Items;
using NUnit.Framework;

namespace GildedRose.Tests.UpdateItemsTests
{
    [TestFixture]
        public class WhenIUpdateAnEventItem
        {
            [Test]
            public void it_should_increase_in_quality()
            {
                var item = new BackstagePassesToATAFKAL80ETCConcert {Quality = 1, SellIn = 11 }.UpdateItem();
                Assert.That(item.Quality, Is.EqualTo(2));
            }

            [TestCase(10)]
            [TestCase(9)]
            [TestCase(8)]
            [TestCase(7)]
            [TestCase(6)]
            public void it_should_increase_quality_by_two_when_there_are_ten_or_less_days_left(int daysLeft)
            {
                var item = new BackstagePassesToATAFKAL80ETCConcert { Quality = 1, SellIn = daysLeft }.UpdateItem();
                Assert.That(item.Quality, Is.EqualTo(3));
            }

            [TestCase(5)]
            [TestCase(4)]
            [TestCase(3)]
            [TestCase(2)]
            [TestCase(1)]
            public void it_should_increase_quality_by_three_when_there_are_five_days_left(int daysLeft)
            {
                var item = new BackstagePassesToATAFKAL80ETCConcert { Quality = 1, SellIn = daysLeft }.UpdateItem();
                Assert.That(item.Quality, Is.EqualTo(4));
            }

            [Test]
            public void it_should_drop_quality_to_zero_when_sell_in_has_passed()
            {
                var item = new BackstagePassesToATAFKAL80ETCConcert {  Quality = 1, SellIn = 0 }.UpdateItem();
                Assert.That(item.Quality, Is.EqualTo(0));
            }

            [Test]
            public void sell_in_should_decrement_normally()
            {
                var item = new BackstagePassesToATAFKAL80ETCConcert { Quality = 1, SellIn = 1 }.UpdateItem();
                Assert.That(item.SellIn, Is.EqualTo(0));
            }
        }
    
}