using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GizatullinAP.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results =
            [
                (x > y),
                (x == y),
                (x < y),
                (x <= y),
                (x >= y + 5000),
                (x != y + 310),
            ];
            return results;
        }
    }
}