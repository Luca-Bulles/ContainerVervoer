using System;

namespace ContainerVervoer_Interfaces
{
    public interface IShip
    {
        int CalculateBalance(int shipWeight);
        int CalculateWeight(int weight);
        int CalculateMargins(int baseMargin);
    }
}
