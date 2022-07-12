using System;
using TriangleTracker;

public class Program
{
  static void Main()
  {
    Triangle testTriangle = new Triangle();

    Console.WriteLine("Please enter side 1");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter side 2");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter side 3");
    int C = int.Parse(Console.ReadLine());
  
    if (!testTriangle.IsValidTriangle(A,B,C)){
      Console.WriteLine("This is not a valid triangle");
    }
    else if (testTriangle.IsScalene(A,B,C)){
      Console.WriteLine("This is a scalene triangle");
    }
    else if (testTriangle.IsEquilateral(A,B,C)){
      Console.WriteLine("This is an equilateral triangle");
    }
    else if (testTriangle.IsIsosceles(A,B,C)){
      Console.WriteLine("This is an isosceles triangle");
    }
  }
}