using System;
using System.Collections.Generic; //remove if not using Dictionary in app 
using TriangleTracker;
class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter three triangle side lengths separated by spaces: ");
    string inputString = Console.ReadLine();
    string[] values = inputString.Split(" ");
    int side1 = int.Parse(values[0]);
    int side2 = int.Parse(values[1]);
    int side3 = int.Parse(values[2]);
    Triangle triangle = new Triangle(side1, side2, side3);
    if (!triangle.IsTriangle())
    {
      Console.WriteLine("These numbers do not make a triangle.");
    }
    else if (triangle.IsEquilateral())
    {
      Console.WriteLine("This is an equilateral triangle.");
    }
    else if (triangle.IsIsosceles())
    {
      Console.WriteLine("This is an isosceles triangle.");
    }
    else
    {
      Console.WriteLine("This is a scalene triangle.");
    }
    Main();
  }
}