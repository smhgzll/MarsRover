using MarsRover.Domain.Model;

namespace MarsRover.Tests.XUnit.Model
{
    public class RoverControllerTestParameter
    {
        public Point Point { get; set; }
        public Direction Direction { get; set; }
        public string SequenceOfCommands { get; set; }
        public string Expected { get; set; }
    }
}
