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
}


///* Abstraction -> Shows only what's necessary
///* Encapsulation -> Hide complexity
///* Inheritance -> Defines parent-child relationship
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
