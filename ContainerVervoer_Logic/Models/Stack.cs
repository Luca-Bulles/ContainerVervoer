using System;
using System.Collections.Generic;
using System.Text;


namespace ContainerVervoer_Logic
{
    public class Stack
    {
        public int Capacity { get; set; }
        public List<Container> Containers { get; private set; }

        public Stack()
        {
            Containers = new List<Container>();
            Capacity = 5;
        }
        public void Add(Container container)
        {
            Containers.Add(container);
                Capacity--;

        }

        public void Remove(Container container)
        {
            Containers.Remove(container);
            Capacity++;
        }

       

        public int CheckValuablesInStack()
        {
            int amountOfValuables = 0;
            foreach (var container in Containers)
            {
                if (container.IsValuable)
                    amountOfValuables++;
                
            }

            return amountOfValuables;
        }

        public int CheckCooledInStack()
        {
            int amountOfCooled = 0;
            foreach (var container in Containers)
            {
                if (container.IsCooled)
                    amountOfCooled++;
                
            }

            return amountOfCooled;
        }
    }
}
