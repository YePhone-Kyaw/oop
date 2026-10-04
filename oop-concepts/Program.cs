namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Validate();

            Manager manager = new Manager();
            manager.name = "Zayden";
            manager.Management();
            manager.Validate();
            manager.Validate(true);
            manager.Validate(false, 10);

            Employee e = new Manager(); // Dynamic Polymorphism
            e = new Supervisor(); // Dynamic Polymorphism

            var x = "Hello" + "World!";
            var y = 1 + 2;
            var o1 = new SomeClass(10);
            var o2 = new SomeClass(20);
            var o3 = o1 + o2;
        }
    }

    class Employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public virtual void Validate()
        {
            CheckName();
            CheckAddress();
        }
        private void CheckName()
        {

        }
        private void CheckAddress()
        {

        }
    }
    class Manager : Employee
    {
        public void Management()
        {

        }

        public override void Validate()
        {
            // our own logic
        }
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict, int num)
        {
            // our own logic
        }
    }
    class Supervisor : Employee
    {

    }
    class SomeClass
    {
        private int someValue;
        public SomeClass(int val)
        {
            someValue = val;
        }

        public static SomeClass operator + (SomeClass arg1, SomeClass arg2)
        {
            return new SomeClass(arg1.someValue + arg2.someValue);
        }
    }
}


///* Abstraction -> Shows only what's necessary
///* Encapsulation -> Hide complexity
///* Inheritance -> Defines parent-child relationship
///* Polymorphish -> Poly means Many, Morph means change as per situation. It's an ability of an object to perform differently under different conditions.
///*
///* The difference between Abstraction and Encapsulation. 
///*    -1 Abstraction happens during design phase [What has to be shown public]
///*    -2 Encapsulation happens during implementation phase [E.g. The developers add private fields, and public methods to control how data is accessed and modified]
///*    -3 Encapsulation implements Abstration 
///* 
///* Inheritance is to define the parent-child relationship between classes
///* What is is-a relationship? [e.g. Manager is a child of Employee]
///* 
///* What is the use of Vitural keyword or Virtual method? (or) What is Overriding? 
///* Vitual keyword helps us to define some logics in the parent class which can be overridden in the child class
///*
///* What is Overloading? (or) What is method overloading?
///* Overloading means same method names with different signatures in the same class.
///*
///*
///* What is the difference between Overriding and Overloading?
///* Overriding - using virtual keyword in parent class and override in the child class.
///* Overloading - methods with same names with different signatures.
///*
///* Can we implement Polymorphism without Inheritance? [No]
///* To implement Polymorphism, Inheritance is a must.
///* 
///* Two types of Polymorphism [Static Polymorphism and Dynamic Polymorphism]
///* Static polymorphism means compile time polymorphism (It is implemented by Method overloading)
///* Dynamic ploymorphism means run time polymorphism (It is implemented by Method overriding)
///
///  Operator overloading - It's a concept of polymorphism where we can redefine the operators like + sign, - sign, * sign. 
///  E.g. we can use + sign for not only string concatination but also integer addition and something like that.
///  
///  How to do custom operator overloading?
///  Must use public static
///  Must use 'operator' keyword
///  Must return something
///
