using MarsRover.Domain.Model;

namespace MarsRover.Domain.Controller
{
    public class RoverController
    {
        public Point Position { get; private set; }
        public Direction Heading { get; private set; }
        private Terrain Boundaries { get; set; }

        public RoverController(Point position, Direction heading, Terrain boundaries)
        {
            this.Position = position;
            this.Heading = heading;
            this.Boundaries = boundaries;
        }

        public void Move()
        {
            switch (Heading)
            {
                case Direction.East:
                    {
                        if (Position.PosX < Boundaries.Width) // Boundary check!
                            Position.PosX += 1;
                    }
                    break;
                case Direction.North:
                    {
                        if (Position.PosY < Boundaries.Heigth) // Boundary check!
                            Position.PosY += 1;
                    }
                    break;
                case Direction.West:
                    {
                        if (Position.PosX > 0) // Boundary check!
                            Position.PosX -= 1;
                    }
                    break;
                case Direction.South:
                    {
                        if (Position.PosY > 0) // Boundary check!
                            Position.PosY -= 1;
                    }
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            Heading += 90; // Turn ccw in polar coordinate system
            if ((int)Heading == 360) // 360 deg is equals to 0 deg
            {
                Heading = Direction.East;
            }
        }

        public void TurnRight()
        {
            Heading -= 90; // Turn cw in polar coordinate system
            if ((int)Heading == -90) // If we go -90 deg is means we reach to 270 deg in polar coordinate system.
            {
                Heading = Direction.South;
            }
        }

        public void SequenceDemodulator(string sequenceOfCommands)
        {
            var commands = sequenceOfCommands.ToCharArray();
            foreach (var command in commands)
            {
                if (command == 'M')
                    Move();
                if (command == 'L')
                    TurnLeft();
                if (command == 'R')
                    TurnRight();
            }
        }

        public string WhereIsMyRover()
        {
            return string.Format("{0} {1} {2}", Position.PosX, Position.PosY, Heading);
        }
    }
}
