using Strategy_Pattern.Ducks;

namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();

            ducks.Add(new MallardDuck());
            ducks.Add(new RedheadDuck());
            ducks.Add(new RubberDuck());

            foreach(Duck duck in ducks)
            {
                duck.Display();
            }
        }
    }
}