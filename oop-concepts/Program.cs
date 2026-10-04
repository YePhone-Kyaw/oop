namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Validate();
        }
    }

    class Employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public void Validate()
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
}


///* Abstraction -> Shows only what's necessary
///* Encapsulation -> Hide complexity
///*
///* The difference between Abstraction and Encapsulation. 
///*    -1 Abstraction happens during design phase [What has to be shown public]
///*    -2 Encapsulation happens during implementation phase [E.g. The developers add private fields, and public methods to control how data is accessed and modified]
///*    -3 Encapsulation implements Abstration 
