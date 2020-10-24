using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Logic.Interfaces;

namespace ContainerVervoer_Logic.Algorithms
{
    public class StackAlgorithms : IStackAlgorithms
    {
        private Stack _stack;
        public bool CheckStackCapacity(Stack stack)
        {
            return (stack.Containers.Count < stack.Capacity);
        }

        public void AddContainerToStack(Container container, Stack stack)
        {
            if (CheckStackCapacity(stack))
            {
                stack.Containers.Add(container);
            } else
            {
                _stack = new Stack();
                _stack.Containers.Add(container);
            }
        }

    }
}
