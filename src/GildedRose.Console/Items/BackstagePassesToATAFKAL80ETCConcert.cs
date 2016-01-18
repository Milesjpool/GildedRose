namespace GildedRose.Console.Items
{
    public class BackstagePassesToATAFKAL80ETCConcert : Item
    {
        public override int SellIn { get; set; }
        public override int Quality { get; set; }

        public virtual string Name {
            get { return "Backstage passes to a TAFKAL80ETC concert"; }
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;

                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }
        }

        public override void UpdateSellIn()
        {
            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                {
                    Quality = Quality - Quality;
                }
            }
        }
    }
}