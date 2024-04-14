
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            int y = 10;

            Console.WriteLine($"X: {x} - Y: {y}");
            new Car().Test(ref x, ref y);
            Console.WriteLine($"X: {x} - Y: {y}");
           
            string str1 = "str1";
            string str2 = "str2";

            Console.WriteLine(str1 + " " + str2);

            new Car().Test(ref str1, ref str2);

            Console.WriteLine(str1 + " " + str2);
            */
            /*
            Box<string> box1 = new Box<string>("String");
           var box2 = new Box<double>(12.2);
            var box3 = new Box<List<string>>(new List<string>
            {
                "string1",
                "string2"
            });

            var capitals = new Dictionary<string, string>();
            capitals.Add("Test", "Paris");
            capitals.Add("Ukraine", "Kyiv");
            capitals.Add("France", "Paris");

            Console.WriteLine(box1.GetContent());
            Console.WriteLine(box2.GetContent());
            Console.WriteLine(box3.GetContent()[1]);
            Console.WriteLine(capitals["France"]);
            */
            int x = 3;
            int y = 8;
            int z = 2;
            int[] arr = {5,6,2,3,4};
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var stack =new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-5 or 6 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.Write($"X: {x}\nY: {y}\nZ: {z}\n");
                        new Task1().Max(ref x, ref y, ref z);
                        break;
                    case 2:
                        Console.Write($"X: {x}\nY: {y}\nZ: {z}\n");
                        new Task2().Min(ref x, ref y, ref z);
                        break;
                    case 3:
                        new Task3().ArSum(ref arr);
                        break;
                    case 4:
                        stack.Pop();
                        stack.Peek();
                        stack.GetCount();
                        break;
                    case 5:
                        Console.WriteLine("First element but delete: ");
                        queue.Dequeue();
                        Console.WriteLine("First element: ");
                        queue.Peek();
                        Console.WriteLine("Count element: ");
                        queue.GetCount();
                        break;
                    case 6:
                        whil = 1;
                        break;
                }
            }
        }
    }
}
