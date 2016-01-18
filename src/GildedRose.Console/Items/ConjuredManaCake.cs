namespace GildedRose.Console.Items
{
    public class ConjuredManaCake : Item
    {
        public override int SellIn { get; set; }
        public override int Quality { get; set; }

        public virtual string Name
        {
            get { return "Conjured Mana Cake"; }
        }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
        }

        public override void UpdateSellIn()
        {
            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 1;
                }
            }
        }
    }
}