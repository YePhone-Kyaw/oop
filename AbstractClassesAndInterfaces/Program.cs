namespace AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer x = new GoldCustomer();
            x.name = "Test";
            x.productAmount = 100;
            x.CalculateDiscount();

            ICustomer x1 = new SilverCustomer();
            x1.CalculateDiscount();

            ICustomerWithInterest x2 = new SilverCustomer();
            x2.CalculateDiscount();
            x2.CalculateInterest();
        }
    }

    public interface ICustomer
    {
        string name { get; set; }
        string address { get; set; }
        string productName { get; set; }
        decimal productAmount { get; set; }
        decimal CalculateDiscount();
    }

    public interface ICustomerWithInterest : ICustomer
    {
        decimal CalculateInterest();
    }

    public abstract class Customer : ICustomer, ICustomerWithInterest
    {
        public string name { get; set; }
        public string address { get; set; }
        public string productName { get; set; }
        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();

        // public virtual decimal CalculateDiscount()
        // {
        //     throw new NotImplementedException("Will be done by child classes");
        // }

        public decimal CalculateInterest()
        {
            return 0;
        }
    }
    public class GoldCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }
    }
    public class SilverCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 5;
        }
    }
}

/// Abstract class is a partially defined Parent class. There're some implementations which are defined some are left to the child classes to be defined.
/// Normal classes cannot create pure half defined parent class.
/// Because abstract class is a partially defined, we cannot create an instance of it. 
/// 
/// Are Abstract method also virtual methods?
/// Abstract methods in the Abstract classes are also default Virtual methods.
/// 
/// Can we careate an instace of Abstract classes? [No]
/// 
/// Is it necessary or compulsory to implement Abstract methods in child classes?
/// Yes, if there's an abstract method in the parent class, we necessarily need to implement it in the child classes. If not, the child class will give use an error.
/// 
/// Why simple base class replace Abstract class?
/// Even though there're some ways, they are not clean ways to implement to carate pure partially definied classes.
/// 
/// Interfaces [Contract, Multiple inheritance, Signature]
/// 
/// Interface is a Contract. It's a legal binding between developer who implemented the calss and the consumer who is using the class.
/// * Use interface keyword.
/// * All the properties, methods, functions are just pure signature. They don't have any logic.
/// * In interface, we can only have pure signature, we can't write any logic.
/// * By default, all the properties, methods, functions inside interfaces are public (access modifier).
/// 
/// Can we write logic in interface? [No]
/// Can we define methods as private, protected in interface? [No, it's public by default]
/// Can we careate an instace of Interface or Abstract classes? [No]
/// 
/// Once we implement the interface, we have to follow all the propertities, all the methods religiously
/// 
/// If we wannt to change the intterfaces, what would be the best practice?
///  - We create a new interface
///  - Inherit from the original interface and add new properties or methods whatever we want in the new interface
/// 
/// Interface is Multiple Inheritance when we want to update the original interface or want to add new properties, methods or whatever to the old interface 
/// without afecting the old one.
/// In that situation, we use multiple inheritance which is for versioning.
/// 
/// Difference between Abstract Calss and Interface
/// - Abstract class is a prtially defined parent class.
/// - Interface is just the structure and cannot add any logic.
/// - Abstract class has the common logics that share for the child classes.
/// 
/// 1 - Interface is the Planning Abstraction phase [e.g. ICustomer]
/// 2 - The abstract class is created and we define the common logic [e.g. abstract Customer class]
/// 3 - Full calsses are created as concrete classes [e.g. Gold and silber customers]
/// 
/// ** Interfaces are implemented, while abstract classes are inherited.
/// ** Even though the abstract calss can act like interface, but they cannot do multiple inheritance.
///
