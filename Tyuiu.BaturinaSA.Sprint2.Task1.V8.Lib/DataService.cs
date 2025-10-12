using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaturinaSA.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (d > c);
            res[1] = (a + 2 > b) & (d < b);
            res[2] = (b + 3 < a) || (d > a);
            res[3] = (a + 2 > b) && (c > d);
            res[4] = !(!res[1]);
            res[5] = (c < d) ^ (b >= a);

            return res;
        }
    }
}