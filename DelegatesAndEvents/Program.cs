namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileSearch fileSearch = new MyFileSearch();
            fileSearch.publisher += Subscriber1;
            fileSearch.publisher += Subscriber2;
            // fileSearch.publisher = null;

            Console.WriteLine("File search started...");
            Task.Run(() => fileSearch.Search("D://Sharpening")); // Non blocking call
            // fileSearch.Search("D://Sharpening"); // Blocking call

            Console.WriteLine("Continue executing program...");
            Console.ReadLine();
        }

        static void Subscriber1(string fileName)
        {
            Console.WriteLine(fileName);
        }
        static void Subscriber2(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }

    public class MyFileSearch
    {
        public delegate void searchMethod(string search); // Create Delegate
        public event searchMethod publisher = null; // Create instance of delegate
        public void Search(string dir)
        {
            try
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    publisher(file);
                }

                foreach (string d in Directory.GetDirectories(dir))
                {
                    publisher(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/// ***** Delegate *****
/// Delegate is a pointer to a function
/// Delegates are callbacks which helps to communicate between async and parallel execution.
/// Delegate defines a method signature that other methods must match
/// This allows methods to be passed around like variables
/// 
/// ***** Multicast delegates *****
/// Multicast Delegates is the one we attach multiple functions to the delegate
/// For the multicast delegates, we need to use += or -= sign.
/// Use += to attach a method
/// Use -= to detach a method
/// All attached methods are called in the order they were added
/// 
/// ***** Events *****
/// Events use Delegates internally.
/// Events are encapsulation over delegates.
/// They encapsulate delegates and make them safe.
/// Event helps us to implement pure publisher - subscriber (or) observable - observer model
/// 
/// Events Vs Delegates
/// Delegates are for callbacks, not encapsulated
/// Events are publisher - subscriber model, encapsulated
///

