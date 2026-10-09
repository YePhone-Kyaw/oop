namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileSearch fileSearch = new MyFileSearch();
            fileSearch.SendData += Receiver1;
            fileSearch.SendData += Receiver2;

            Console.WriteLine("File search started...");
            Task.Run(() => fileSearch.Search("D://Sharpening")); // Non blocking call
            // fileSearch.Search("D://Sharpening"); // Blocking call

            Console.WriteLine("Continue executing program...");
            Console.ReadLine();
        }

        static void Receiver1(string fileName)
        {
            Console.WriteLine(fileName);
        }
        static void Receiver2(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }

    public class MyFileSearch
    {
        public delegate void searchMethod(string search); // Create Delegate
        public searchMethod SendData = null; // Create instance of delegate
        public void Search(string dir)
        {
            try
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    SendData(file);
                }

                foreach (string d in Directory.GetDirectories(dir))
                {
                    SendData(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/// Delegate is a pointer to a function
/// Delegates are callbacks which helps to communicate between async and parallel execution.
/// Delegate defines a method signature that other methods must match
/// This allows methods to be passed around like variables
/// 
/// Multicast Delegates is the one we attach multiple functions to the delegate
/// For the multicast delegates, we need to use += or -= sign
///

