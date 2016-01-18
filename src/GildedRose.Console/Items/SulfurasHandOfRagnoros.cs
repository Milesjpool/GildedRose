namespace GildedRose.Console.Items
{
    public class SulfurasHandOfRagnaros : Item
    {
        public override int SellIn { get; set; }
        public override int Quality { get; set; }
        public virtual string Name { get { return "Sulfuras, Hand of Ragnaros"; } }

        public override void UpdateQuality()
        {
        }

        public override void UpdateSellIn()
        {
        }
    }
}