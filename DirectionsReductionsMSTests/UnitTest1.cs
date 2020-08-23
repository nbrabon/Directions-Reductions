using DirectionsReductionsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace DirectionsReductionsMSTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KataTests1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            CollectionAssert.AreEqual(b, DirReduction.dirReduc(a));
        }

        [TestMethod]
        public void KataTests2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            CollectionAssert.AreEqual(b, DirReduction.dirReduc(a));
        }

        [TestMethod]
        public void TestNull()
        {
            DirReduction.dirReduc(null);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            string[] empty = Array.Empty<string>();
            DirReduction.dirReduc(empty);
        }

    }
}
