using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsValidTriangle_NoTwoLengthsAreLessThanTheThird_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsValidTriangle(3,4,5));
    }
    [TestMethod]
    public void IsValidTriangle_NoTwoLengthsAreLessThanTheThird_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsValidTriangle(3,4,8));
    }

    [TestMethod]
    public void IsScalene_NoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsScalene(3,4,5));
    }
    [TestMethod]
    public void IsScalene_NoSidesAreEqual_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsScalene(4,4,5));
    }

    [TestMethod]
    public void IsEquilateral_AllSidesEqual_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEquilateral(4,4,4));
    }
    [TestMethod]
    public void IsEquilateral_AllSidesEqual_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsEquilateral(5,4,4));
    }
    
    [TestMethod]
    public void IsIsosceles_TwoSidesEqual_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(4,4,5));
    }
    [TestMethod]
    public void IsIsosceles_TwoSidesEqual_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsIsosceles(3,4,5));
    }
  }
}