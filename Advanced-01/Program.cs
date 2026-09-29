using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



//q1 نظري

//A Generic Class is a class that can work with different data types using a type parameter such as T, without needing to create a separate class for each data type.

//Why do we use Generics ?

//Code Reusability: Write one class that works with multiple data types.

//Type Safety: Prevent incompatible data types at compile time.

//Less Code Duplication: Avoid writing multiple classes for similar functionality.

//Better Performance: Reduce boxing and unboxing when working with value types.

//Maintainability: Make code easier to manage and update.