using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaturinaSA.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 135 == y;
            res[1] = x != 105;
            res[2] = x < y;
            res[3] = x + 720 > y;
            res[4] = x >= y;
            res[5] = x + 687 <= y;

            return res;
        }
    }
}