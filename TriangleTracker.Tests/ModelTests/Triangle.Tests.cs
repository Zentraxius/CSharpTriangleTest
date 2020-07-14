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

    /*[TestMethod]
    public void IsEquilateral_CheckIfTriangleIsEquilateral_True()
    {
      Triangle triangle = new Triangle()
      Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }*/
  }
}