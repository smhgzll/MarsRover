using MarsRover.Domain.Model;
using MarsRover.Domain.Rover;
using MarsRover.Tests.XUnit.Model;
using MarsRover.Tests.XUnit.Theory;
using Xunit;

namespace MarsRover.Tests.XUnit
{
    public class RoverControllerTests
    {
        private Terrain Terrain = new Terrain(5, 5);

        [Theory, ClassData(typeof(RoverControllerTestThoryData))]
        public void WhereIsMyRover_ClassData_Tests(RoverControllerTestParameter parameter)
        {
            var genericRover = new Rover(parameter.Point, parameter.Direction, Terrain);
            genericRover.RoverController.SequenceDemodulator(parameter.SequenceOfCommands);
            var actual = genericRover.RoverController.WhereIsMyRover();
            Assert.Equal(parameter.Expected, actual);
        }

        [Theory, InlineData(new object[] { 1, 2, Direction.North, "LMLMLMLMM", "1 3 North" })]
        public void WhereIsMyRover_1_2_North_LMLMLMLMM_is_13North(int positionX, int positionY, Direction direction, string commands, string expected)
        {
            var curiosity = new Rover(new Point(positionX, positionY), direction, Terrain);
            curiosity.RoverController.SequenceDemodulator(commands);
            var actual = curiosity.RoverController.WhereIsMyRover();
            Assert.Equal(expected, actual);
        }

        [Theory, InlineData(new object[] { 3, 3, Direction.East, "MMRMMRMRRM", "5 1 East" })]
        public void WhereIsMyRover_3_3_East_MMRMMRMRRM_is_51East(int positionX, int positionY, Direction direction, string commands, string expected)
        {
            var opportunity = new Rover(new Point(positionX, positionY), direction, Terrain);
            opportunity.RoverController.SequenceDemodulator(commands);
            var actual = opportunity.RoverController.WhereIsMyRover();
            Assert.Equal(expected, actual);
        }

    }
}
