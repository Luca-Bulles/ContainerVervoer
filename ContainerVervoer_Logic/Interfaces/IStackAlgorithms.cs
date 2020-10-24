using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer_Logic.Interfaces
{
    public interface IStackAlgorithms
    {
        bool CheckStackCapacity(Stack stack);
        void AddContainerToStack(Container container, Stack stack);
    }
}
