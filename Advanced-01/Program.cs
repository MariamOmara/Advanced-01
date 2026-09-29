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

        //Q5
        //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
        //    {
        //        return a.CompareTo(b) > 0 ? a : b;
        //    }
        //}
        //}

        //Q6
        //        public interface IRepository<T>
        //        {
        //            void Add(T entity);
        //            T GetById(int id);
        //            void Update(T entity);
        //            void Delete(int id);
        //        }
        //    }
        //}


        //Q7
        //        public class Container<T> where T : struct
        //        {
        //            public T Value { get; set; }
        //        }
        //    }
        //}


        //Q8
        //        public class Container<T> where T : class
        //        {
        //            public T Value { get; set; }
        //        }
        //    }
        //}

        //Q9
        //        public class Container<T> where T : new()
        //        {
        //            public T Create()
        //            {
        //                return new T();
        //            }
        //        }
        //    }
        //}


        //Q10
        //        public interface IPrintable
        //        {
        //            void Print();
        //        }

        //        public class Container<T> where T : IPrintable
        //        {
        //            public void Display(T item)
        //            {
        //                item.Print();
        //            }
        //        }
        //    }
        //}


        //Q11
        //        public class Animal
        //        {
        //        }

        //        public class Container<T> where T : Animal
        //        {
        //            public T Value { get; set; }
        //        }
        //    }
        //}


        //Q12
        //        public class Container<T> where T : class, IComparable<T>, new()
        //        {
        //            public T Value { get; set; }

        //            public Container()
        //            {
        //                Value = new T();
        //            }
        //        }
        //    }
        //}



        //Q13
//        public static T GetDefault<T>()
//        {
//            return default(T);
//        }
//    }
//}










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