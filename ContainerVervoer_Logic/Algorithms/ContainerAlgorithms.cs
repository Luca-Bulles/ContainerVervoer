using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Logic.Interfaces;

namespace ContainerVervoer_Logic.Algorithms
{
    public class ContainerAlgorithms : IContainerAlgorithms
    {
        private int _maxWeight = 150000;
        public bool CheckContainerWeight(Container container)
        {
            return container.Weight <= _maxWeight;
        }

        public bool CheckIfValuableOrCooled(Container container)
        {
            return container.IsCooled || container.IsValuable;
        }
    }
}
