namespace MarsRover
{
    public class Rover
    {
        public RoverController RoverController { get; private set; }
        /// <summary>
        /// Land a new rover.
        /// </summary>
        /// <param name="startingPosition">Landing position.</param>
        /// <param name="heading">Landing direction.</param>
        /// <param name="terrain">Where to land.</param>
        public Rover(Point startingPosition, Direction heading, Terrain terrain)
        {
            RoverController = new RoverController(startingPosition, heading, terrain);
        }
    }
}
