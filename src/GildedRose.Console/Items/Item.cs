namespace GildedRose.Console.Items
{
    public abstract class Item
    {
        public abstract int SellIn { get; set; }
        public abstract int Quality { get; set; }
        public abstract void UpdateQuality();
        public abstract void UpdateSellIn();
    }
}