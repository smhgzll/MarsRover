using MarsRover.Domain.Model;
using MarsRover.Domain.Rover;

namespace MarsRover.Tests.Model
{
    public class ControllerTestParameter
    {
        public Terrain Terrain { get; set; }
        public Rover Rover { get; set; }
        public string Actual { get; set; }
        public string Expected { get; set; }
    }
}
