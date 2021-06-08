namespace ColorBalls
{
    public class Ball
    {
        private Color color;
        private float radius;
        private int timesThrow;

        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            timesThrow = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if(radius > 0)
            {
                timesThrow++;
            }
        }

        public int GetTimeThrow() => timesThrow;

        public Color GetColor() => color;
    } 
}