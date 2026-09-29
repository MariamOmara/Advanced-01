using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_01
{
    internal class Program
    {
        //Q4
//public static void Swap<T>(ref T a, ref T b)
//        {
//            T temp = a;
//            a = b;
//            b = temp;
//        }
    }
    }











//Q3
//public class Pair<TKey, TValue>
//{
//    public TKey Key { get; set; }
//    public TValue Value { get; set; }
//}


//  Q2
//public class Container<T>
//{
//    private T item;

//    public void Add(T value)
//    {
//        item = value;
//    }

//    public T Get()
//    {
//        return item;
//    }
//}



//q1 نظري

//A Generic Class is a class that can work with different data types using a type parameter such as T, without needing to create a separate class for each data type.

//Why do we use Generics ?

//Code Reusability: Write one class that works with multiple data types.

//Type Safety: Prevent incompatible data types at compile time.

//Less Code Duplication: Avoid writing multiple classes for similar functionality.

//Better Performance: Reduce boxing and unboxing when working with value types.

//Maintainability: Make code easier to manage and update.