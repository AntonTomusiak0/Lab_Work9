
namespace ConsoleApp13
{
    internal class Task2
    {
        public void Min<T>(ref T x, ref T y, ref T z)
        {
            dynamic min = x;
            if (y < min)
            {
                min = y;
            }
            if (z < min)
            {
                min = z;
            }
            Console.WriteLine(min);
        }
    }
}
