using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaturinaSA.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4))
                return true;
            if ((x == 3) && (x == 4) && (y == 7))
                return true;
            if ((x == 4) && (y >= 8) && (y <= 13))
                return true;
            if ((x == 3) && (y == 11))
                return true;
            if ((x == 5) && (x == 6) && (y == 14))
                return true;
            if ((x >= 5) && (x <= 9) && (y >= 5) && (y <= 7))
                return true;
            if ((x == 9) && (y >= 3) && (y <= 4))
                return true;
            if ((x >= 8) && (x <= 10) && (y >= 8) && (y <= 12))
                return true;
            if ((x >= 11) && (x <= 12) && (y == 11))
                return true;
            if ((x == 10) && (y == 7))
                return true;
            if ((x == 12) && (y >= 3) && (y <= 6))
                return true;
            if ((x == 13) && (y == 6))
                return true;
            if ((x >= 11) && (x <= 13) && (y >= 7) && (y <= 8))
                return true;

            else
            {
                return false;
            }

            return res;
        }

    }
}