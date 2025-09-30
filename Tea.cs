namespace Template_Method
{
    public class Tea : HotBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddSugar()
        {
            Console.WriteLine("Adding sugar to tea");
        }
    }
}