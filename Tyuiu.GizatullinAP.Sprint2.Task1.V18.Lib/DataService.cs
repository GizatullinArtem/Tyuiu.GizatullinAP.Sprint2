using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GizatullinAP.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (b == d);
            res[1] = (b > d) & (b != a);
            res[2] = (a >= c) || (a != d);
            res[3] = (b != c) && (b < c);
            res[4] = !(b == c);
            res[5] = (b >= d) ^ (d != c);
            return res;
        }
    }
}