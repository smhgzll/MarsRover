using MarsRover.Domain.Model;
using MarsRover.Domain.Rover;
using MarsRover.Tests.Model;
using MarsRover.Tests.Theory;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverControllerTests
    {
        private Terrain Terrain = new Terrain(5, 5);

        [Theory, ClassData(typeof(RoverControllerTestThoryData))]
        public void Test1(RoverControllerTestParameter parameter)
        {
            var genericRover = new Rover(parameter.Point, parameter.Direction, Terrain);
            genericRover.RoverController.SequenceDemodulator(parameter.SequenceOfCommands);
            var actual = genericRover.RoverController.WhereIsMyRover();
            Assert.Equal(parameter.Expected, actual);
        }

        [Theory, InlineData(new object[] { 1, 2, Direction.North, "LMLMLMLMM", "1 3 North" })]
        public void Test2(int positionX, int positionY, Direction direction, string commands, string expected)
        {
            var curiosity = new Rover(new Point(positionX, positionY), direction, Terrain);
            curiosity.RoverController.SequenceDemodulator(commands);
            var actual = curiosity.RoverController.WhereIsMyRover();
            Assert.Equal(expected, actual);
        }

        [Theory, InlineData(new object[] { 3, 3, Direction.East, "MMRMMRMRRM", "5 1 East" })]
        public void Test3(int positionX, int positionY, Direction direction, string commands, string expected)
        {
            var opportunity = new Rover(new Point(positionX, positionY), direction, Terrain);
            opportunity.RoverController.SequenceDemodulator(commands);
            var actual = opportunity.RoverController.WhereIsMyRover();
            Assert.Equal(expected, actual);
        }

    }
}
