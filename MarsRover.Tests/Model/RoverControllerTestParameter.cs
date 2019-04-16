using MarsRover.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Tests.Model
{
    public class RoverControllerTestParameter
    {
        public Point Point { get; set; }
        public Direction Direction { get; set; }
        public string SequenceOfCommands { get; set; }
        public string Expected { get; set; }
    }
}
