using MarsRover.Domain.Model;
using MarsRover.Tests.XUnit.Model;
using Xunit;

namespace MarsRover.Tests.XUnit.Theory
{
    public class RoverControllerTestThoryData : TheoryData<RoverControllerTestParameter>
    {
        public RoverControllerTestThoryData()
        {
            Add(new RoverControllerTestParameter
            {
                Point = new Point(1, 2),
                Direction = Direction.North,
                SequenceOfCommands = "LMLMLMLMM",
                Expected = "1 3 North"
            });

            Add(new RoverControllerTestParameter
            {
                Point = new Point(3, 3),
                Direction = Direction.East,
                SequenceOfCommands = "MMRMMRMRRM",
                Expected = "5 1 East"
            });
        }
    }
}
