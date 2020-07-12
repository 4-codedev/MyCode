using System;
namespace AlgabraPointPloter
{
    public class Algebra
    {
        public Algebra()
        {

        }
        public int Linear(int a, int b, int c, int x)
        {
            int q = a * x;
            int d = c - q;
            int y = d / b;
            return y;
        }

        public int Parabola(int x)
        {
            int y = Math.Pow(x, 2);
            return y;
        }
        public int Hyperbola(int x, int n)
        {
            int y = n / x;

            return y;
        }
    }
}