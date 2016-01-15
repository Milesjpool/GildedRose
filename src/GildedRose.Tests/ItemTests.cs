using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
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
    }
}
