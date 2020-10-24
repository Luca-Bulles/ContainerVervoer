using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer_Logic.Interfaces
{
    public interface IContainerAlgorithms
    {
        bool CheckContainerWeight(Container container);
        bool CheckIfValuableOrCooled(Container container);

    }
}
