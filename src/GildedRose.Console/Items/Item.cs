namespace GildedRose.Console.Items
{
    public class Item
    {
        public virtual string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}