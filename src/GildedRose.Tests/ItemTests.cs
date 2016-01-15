using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    class ItemsHaveCorrectNamesTests
    {
        [Test]
        public void AgedBrieHasCorrectName()
        {
            Assert.That(new AgedBrie().Name, Is.EqualTo("Aged Brie"));
        }
    }
}
