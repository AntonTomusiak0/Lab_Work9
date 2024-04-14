
namespace ConsoleApp13
{
    internal class Task1
    {
        public void Max<T>(ref T x, ref T y, ref T z)
        {
            dynamic max = x;
            if(y > max)
            {
                max = y;
            }
            if(z > max)
            {
                max = z;
            }
            Console.WriteLine(max);
        }
    }
}
