using System;
using System.Collections;
using DirectionsReductionsLibrary;
using NUnit.Framework;

[TestFixture]
public class DirReductionTests
{

    [Test]
    public void Test1()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }
    [Test]
    public void Test2()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }
}
