using System;
using FsCheck;
using System.Collections.Generic;
using System.Linq;
using TestMain;
namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testclass = new TestClass();
            Prop.ForAll(testclass.Test1)
                .QuickCheck();

        }
    }
}
