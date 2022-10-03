using LinkedListLibrary;
using System.Collections.Generic;

namespace StackCompositionLibrary
{
    public class StackComposition
    {
        private List stack;

        // Construct empty stack
        public StackComposition()
        {
            stack = new List("stack");
        }

        // Add object to stack
        public void Push(object dataValue)
        {
            stack.InsertAtFront(dataValue);
        }

        // Remove object from stack
        public object Pop()
        {
            return stack.RemoveFromFront(); 
        }

        // Determine whether stack is empty
        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }

        // Output stack contents
        public void Display()
        {
            stack.Display();
        }
    }
}