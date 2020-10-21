using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer_Logic.Interfaces
{
    public interface IRow
    {
        void AddStack(Stack stack);
        void Remove(Stack stack);
        int CalculateTotalValuables();
        int CalculateTotalCooled();
    }
}
