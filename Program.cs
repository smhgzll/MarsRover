using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var terrain = new Terrain(5, 5);

            var curiosity = new Rover(new Point(1, 2), Direction.North, terrain);
            curiosity.RoverController.SequenceDemodulator("LMLMLMLMM");

            var opportunity = new Rover(new Point(3, 3), Direction.East, terrain);
            opportunity.RoverController.SequenceDemodulator("MMRMMRMRRM");

            var curiosityPos = curiosity.RoverController.WhereIsMyRover();
            var opportunityPos = opportunity.RoverController.WhereIsMyRover();

            Console.WriteLine("Coordinates Of Curiosity Rover : " + curiosityPos);
            Console.WriteLine("Coordinates Of Opportunity Rover : " + opportunityPos);

            Console.ReadKey();
        }
    }
}
