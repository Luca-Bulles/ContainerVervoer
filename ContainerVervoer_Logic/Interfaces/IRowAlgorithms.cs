using System;
using System.Collections.Generic;
using System.Text;
using ContainerVervoer_Logic.Models;

namespace ContainerVervoer_Logic.Interfaces
{
    public interface IRowAlgorithms
    {
        bool CheckRowCapacity(Row row);
    }
}
