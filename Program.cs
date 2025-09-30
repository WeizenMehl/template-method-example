namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            HotBeverage tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine("\n");
            HotBeverage coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}