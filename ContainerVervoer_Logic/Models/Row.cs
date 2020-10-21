using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Logic.Interfaces;

namespace ContainerVervoer_Logic.Models
{
    public class Row : IRow
    {
        public List<Stack> Stacks { get; private set; }

        public Row()
        {
            Stacks = new List<Stack>();
        }
        public void AddStack(Stack stack)
        {
            Stacks.Add(stack);
        }

        public void Remove(Stack stack)
        {
            Stacks.Remove(stack);
        }

        public int CalculateTotalValuables()
        {
            int totalValuablesInRow = 0;
            foreach (var stack in Stacks)
            {
                for (int i = 0; i < stack.Containers.Count; i++)
                {
                    if (stack.Containers[i].IsValuable)
                        totalValuablesInRow++;
                    
                }
            }

            return totalValuablesInRow;
        }

        public int CalculateTotalCooled()
        {
            int totalCooledInRow = 0;
            foreach (var stack in Stacks)
            {
                for (int i = 0; i < stack.Containers.Count; i++)
                {
                    if (stack.Containers[i].IsCooled)
                        totalCooledInRow++;
                }
            }
            return totalCooledInRow;
        }
    }
}
