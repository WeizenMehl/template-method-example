namespace Template_Method
{
    public class Coffee : HotBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}