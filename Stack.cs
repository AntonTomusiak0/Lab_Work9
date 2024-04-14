
namespace ConsoleApp13
{
    internal class Stack<T>
    {
        public List<T> list = new List<T>();

        public void Push(T num)
        {
            list.Add(num);
        }
        public void Pop()
        {
            if(list.Count == 0)
            {
                Console.WriteLine("ERROR EMPTY");
            }
            T num = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Console.WriteLine(num);
        }
        public void Peek()
        {
            if(list.Count == 0)
            {
                Console.WriteLine("ERROR EMPTY");
            }
            Console.WriteLine(list[list.Count - 1]);
        }
        public void GetCount()
        {
            Console.WriteLine(list.Count);
        }
    }
}
