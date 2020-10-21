using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Interfaces;

namespace ContainerVervoer_Logic.Models
{
    public class Ship : IShip
    {
        public int MinimumWeight { get; private set; }
        public int MaximumStackWeight { get; private set; }
        public int ShipCapacity { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }
        public int LeftSideRows { get; private set; }
        public int RightSideRows { get; private set; }

        public Ship(int minimumW, int maxStackW, int shipCap, int length, int width, int lSide, int rSide)
        {
            MinimumWeight = minimumW;
            MaximumStackWeight = maxStackW;
            ShipCapacity = shipCap;
            Length = length;
            Width = width;
            LeftSideRows = lSide;
            RightSideRows = rSide;
        }

        public int CalculateOvercapacity()
        {
            return ShipCapacity / 100 * 70;
        }

        public int CalculateWeight()
        {
            return Length * Width * MaximumStackWeight;
        }
    }
}
