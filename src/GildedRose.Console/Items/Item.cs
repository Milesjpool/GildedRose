namespace GildedRose.Console.Items
{
    public abstract class Item
    {
        public virtual string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}