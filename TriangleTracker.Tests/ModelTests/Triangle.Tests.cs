using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker; // ewProject

namespace TriangleTracker.Tests
{
  [TestClass]
  public class BusinessLogicTests
  {
    [TestMethod]
    public void Triangle_CreatingTriangleObject_TriangleObject()
    {
      Triangle triangle = new Triangle(2, 3, 4);
      Assert.AreEqual(3, triangle.Side2);
    }

    [TestMethod]
    public void IsEquilateral_CheckIfTriangleIsEquilateral_True()
    {
      Triangle triangle = new Triangle(5, 5, 5);
      Assert.AreEqual(true, triangle.IsEquilateral());
    }

    [TestMethod]
    public void IsIsosceles_CheckIfTriangleIsIsosceles_True()
    {
      Triangle triangle = new Triangle(5,5,7);
      Assert.AreEqual(true, triangle.IsIsosceles());
    }

    [TestMethod]
    public void IsTriangle_CheckIfInputIsTriangle_True()
    {
      Triangle triangle = new Triangle(5,5,5);
      Assert.AreEqual(true, triangle.IsTriangle());
    }
  }
}