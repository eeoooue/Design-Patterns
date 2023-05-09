using Factory_Method.Sandwiches;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The Factory Method design pattern is a Creational design pattern which defines an interface
            //for creating an object, but doesn't specify what objects the individual implementations of that
            //interface will instantiate.

            //All that means is that when using this pattern, you can define certain methods and properties
            //of object that will be common to all objects created using the Factory Method, but let the
            //individual Factory Methods define what specific objects they will instantiate.

            //The Participants
            //• The Product defines the interfaces of objects that the factory method will create.
            //• The ConcreteProduct objects implement the Product interface.
            //• The Creator declares the factory method, which returns an object of type Product.
            //• The ConcreteCreator objects overrides the factory method to return an instance of a Concrete Product


            //In our example

            List<Sandwich> sandwiches = new List<Sandwich>();

            sandwiches.Add(new TurkeySandwich());
            sandwiches.Add(new Dagwood());

            int count = 1;
            foreach(Sandwich sandwich in sandwiches)
            {
                Console.WriteLine($"sandwich #{count++} has {sandwich.Ingredients.Count} ingredients!");
            }
        }
    }
}