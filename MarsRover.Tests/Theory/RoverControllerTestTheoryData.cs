using MarsRover.Domain.Model;
using MarsRover.Domain.Rover;
using MarsRover.Tests.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests.Theory
{
    public class RoverControllerTestTheoryData : TheoryData<ControllerTestParameter>
    {
        public RoverControllerTestTheoryData()
        {
            var terrain = new Terrain(5, 5);
            Add(new ControllerTestParameter
            {
                Terrain = terrain,
                Rover = new Rover(new Point(1, 2), Direction.North, terrain),
                Actual = "LMLMLMLMM",
                Expected = "1 3 North"
            });
        }
    }
}
