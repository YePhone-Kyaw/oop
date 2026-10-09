namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Women women = new Women();
            Console.ReadLine();
        }
    }
    
    public class Human
    {
        public int i = 0;
        public Human()
        {
            Console.WriteLine("Human");
        }
        static Human()
        {
            Console.WriteLine("Static Human");
        }
    }

    public class Women : Human
    {
        public int iw = 0;
        public Women()
        {
            Console.WriteLine("Women");
        }
        static Women()
        {
            Console.WriteLine("Static Women");
        }
    }

    public class Men : Human
    {
        public Men()
        {
            Console.WriteLine("Men");
        }
    }
}

/// ***** Constructors *****
/// Constructor is a special method of a class which gets automatically invoked when the instance of the class is created.
/// 
/// In parent - child (Inheritance), which constructor fires first? [Logically, Parent constructor should fire first]
/// 
/// For the initializers, child initializer fires first.
/// 
/// Child Initializers -> Parent Initializers -> Parent Constructors -> Child Constructors
/// 
/// ***** Static Constructors *****
/// Child Static Constructors -> Parent Static Constructors -> Child Initializers -> Parent Initializers -> Parent Constructors -> Child Constructors
/// 
/// When does static constructor fire? [It fires when we access the class for the first time]
///
