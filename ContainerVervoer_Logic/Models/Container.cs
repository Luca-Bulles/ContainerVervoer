using System;
using System.Collections.Generic;
using System.ComponentModel;
using IContainer = ContainerVervoer_Interfaces.IContainer;

namespace ContainerVervoer_Logic
{
    public class Container : IContainer
    {
        public bool IsValuable { get; private set; }
        public bool IsCooled { get; private set; }
        public int Weight { get; private set; }

        public Container(bool valuable, bool cooled, int weight)
        {
            IsValuable = valuable;
            IsCooled = cooled;
            Weight = weight;
        }
    }
}
