namespace ColorBalls
{
    public class Color
    {
        private byte Red { get; set; }
        private byte Green; 
        private byte Blue;
        private byte Alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        
        public byte GetGreyscale()
        {
            return (byte)((red + green + blue) / 3);
        }
    }

}