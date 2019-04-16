namespace MarsRover.Domain.Model
{
    public class Point
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Point(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
