namespace AbstractFactorySample
{
    public class CostumeShop
    {
        public IWomanCostume womanCostume;
        public IManCostume manCostume;
        public string description;
        public CostumeShop(ICostumeFactory factory)
        {
            womanCostume = factory.CreateWomanCostume();
            manCostume = factory.CreateManCostume();
            description = factory.Description();
        }

        public string SetUpShopWindow()
        {
            return $"COSTUME SHOP WINDOW\n{description}\n{manCostume.AssembleCostume()}\n{womanCostume.AssembleCostume()}";
        }
    }
}
