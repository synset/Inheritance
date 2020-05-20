using System.Collections.Generic;

namespace StackOfStrings
{
    public class StackOfStrings
    {
        private List<string> data = new List<string>();

        public void Push(string item)
        {
            data.Add(item);
        }
        public bool Pop()
        {
            data.RemoveAt(data.Count - 1);
            return true;
        }
        public string Peek()
        {
            return data[data.Count - 1];
        }
        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}
