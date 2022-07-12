namespace TriangleTracker
{
  public class Triangle
  {
    public bool IsValidTriangle(int A, int B, int C)
    {
      return (A+B > C && B+C > A && A+C > B);
    }
    public bool IsScalene(int A, int B, int C)
    {
      return (A != B && A != C && B != C);
    }
    public bool IsEquilateral(int A, int B, int C)
    {
      return (A == B && A == C && B == C);
    }
    public bool IsIsosceles(int A, int B, int C)
    {
      return (A == B || A == C || B == C);
    }
  }
}
