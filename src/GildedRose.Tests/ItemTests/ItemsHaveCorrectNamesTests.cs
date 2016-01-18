using GildedRose.Console;
using GildedRose.Console.Items;
using NUnit.Framework;

namespace GildedRose.Tests.ItemTests
{
    [TestFixture]
    class ItemsHaveCorrectNamesTests
    {
        [Test]
        public void AgedBrie_has_correct_name()
        {
            var agedBrie = new AgedBrie();
            Assert.That(agedBrie.Name, Is.EqualTo("Aged Brie"));
        }

        [Test]
        public void Plus5DexterityVest_has_correct_name()
        {
            var plus5DexterityVest = new Plus5DexterityVest();
            Assert.That(plus5DexterityVest.Name, Is.EqualTo("+5 Dexterity Vest"));
        }

        [Test]
        public void ElixirOfTheMongoose_has_correct_name()
        {
            var elixirOfTheMongoose = new ElixirOfTheMongoose();
            Assert.That(elixirOfTheMongoose.Name, Is.EqualTo("Elixir of the Mongoose"));
        }

        [Test]
        public void SulfurasHandOfRagnaros_has_correct_name()
        {
            var elixirOfTheMongoose = new SulfurasHandOfRagnaros();
            Assert.That(elixirOfTheMongoose.Name, Is.EqualTo("Sulfuras, Hand of Ragnaros"));
        }

        [Test]
        public void ConjuredManaCake_has_correct_name()
        {
            var elixirOfTheMongoose = new ConjuredManaCake();
            Assert.That(elixirOfTheMongoose.Name, Is.EqualTo("Conjured Mana Cake"));
        }

        [Test]
        public void BackstagePassesToATAFKAL80ETCConcert_has_correct_name()
        {
            var elixirOfTheMongoose = new BackstagePassesToATAFKAL80ETCConcert();
            Assert.That(elixirOfTheMongoose.Name, Is.EqualTo("Backstage passes to a TAFKAL80ETC concert"));
        }
    }
}
