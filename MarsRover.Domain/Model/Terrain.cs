namespace MarsRover.Domain.Model
{
    public class Terrain
    {
        public int Width { get; private set; }
        public int Heigth { get; private set; }

        public Terrain(int width, int heigth)
        {
            Width = width;
            Heigth = heigth;
        }
    }
}
