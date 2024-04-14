
namespace ConsoleApp13
{
    internal class Task3
    {
        public void ArSum<T>(ref T[] arr)
        {
            dynamic sum = 0;
            foreach (T num in arr)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
