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
    public void Isosceles_CheckIfTriangleIsosceles_True()
    {
      Triangle triangle = new Triangle(5,6,7);
      Assert.AreEqual(true, triangle.isosceles());
    }
  }
}