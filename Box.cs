
namespace ConsoleApp13
{
    internal class Box<T>
    {
        public T Value { get; set; }
        private T _content;
        public Box(T content)
        { 
            _content = content;
        }
        public T GetContent() => _content;
        public void SetContent(T content)
        {
            _content = content;
        }
    }
}
