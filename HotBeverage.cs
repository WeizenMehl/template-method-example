namespace Template_Method
{
    public abstract class HotBeverage
    {
        // Template method
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddSugar();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual void AddSugar()
        {
            // Default implementation (no sugar)
        }
    }
}