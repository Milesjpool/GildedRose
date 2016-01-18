namespace GildedRose.Console.Items
{
    public class AgedBrie : Item
    {
        public override int SellIn { get; set; }
        public override int Quality { get; set; }

        public virtual string Name
        {
            get { return "Aged Brie"; }
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }

        public override void UpdateSellIn()
        {
            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }
        }
    }
}