using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Interfaces;

namespace ContainerVervoer_Logic.Models
{
    public class Ship : IShip
    {
        public int CalculateBalance(int shipWeight)
        {
            throw new NotImplementedException();
        }

        public int CalculateWeight(int weight)
        {
            throw new NotImplementedException();
        }

        public int CalculateMargins(int baseMargin)
        {
            throw new NotImplementedException();
        }
    }
}
