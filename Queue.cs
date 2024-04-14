
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp13
{
    internal class Queue<T>
    {
        public T[] arr = new T[10];
        public int head = 0;
        public int tail = -1;
        public int count = 0;
        public void Enqueue(T num)
        {
            if(count == arr.Length)
            {
                Array.Resize(ref arr, arr.Length * 2);
            }
            tail = (tail + 1) % arr.Length;
            arr[tail] = num;
            count++; 
        }
        public void Dequeue()
        {
            if(count == 0) {
                Console.WriteLine("ERROR QUEUE EMPTY");
            }
            T num = arr[head];
            head = (head + 1) % arr.Length;
            count--;
            Console.WriteLine(num);
        }
        public void Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("ERROR QUEUE EMPTY");
            }
            Console.WriteLine(arr[head]);
        }
        public void GetCount()
        {
            Console.WriteLine(count);
        }
    }
}
