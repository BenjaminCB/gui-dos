using System;
using FsCheck;

namespace gui_dos_test
{
    namespace gui_dos_test
    {
        public class TestClass
        {
            public Func<Order, bool> FuncToTest = (xs) => true;
            public Gen<T> OrderDataGenerator<T>(T[] xs)
            {
                return from i in Gen.Choose(0, xs.Length - 1) select xs[i];
            }
        }
        public class Order
        {
            public string name;
            string id;
        }
        class Program
        {

            static void Main(string[] args)
            {

                TestClass testclass = new TestClass();
                Prop.ForAll(testclass.FuncToTest).QuickCheck();

            }
        }
    }

}
