namespace Desmos.Components.Pages
{
    public class Point
    {
        public double x;
        public double y;
        public Point[] points;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0, 0)
        {

        }

        public void Setx(double x)
        {
            this.x = x;
        }
        public double Getx()
        {
            return this.x;
        }

        public void Sety(double y)
        {
            this.y = y;
        }
        public double Gety()
        {
            return this.y;
        }

        public double Distance(Point P)
        {
            double dx2 = Math.Pow(this.x - P.Getx(), 2);
            double dy2 = Math.Pow(this.y - P.Gety(), 2);
            return Math.Sqrt(dx2 + dy2);
        }

        public Point Midpoint(Point P)
        {
            double midX = (this.x + P.x) / 2;
            double midY = (this.y + P.y) / 2;

            return new Point(midX, midY);
        }

        public override string ToString()
        {
            return $"({this.x} , {this.y})";
        }

    }
}
