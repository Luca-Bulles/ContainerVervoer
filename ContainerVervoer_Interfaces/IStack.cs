using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer_Interfaces
{
    public interface IStack
    {
        void Add(Container container);
        void Remove(Container container);
        int CheckValuablesInStack();
        int CheckCooledInStack();
    }
}
