namespace F26ReviewForm
{
    public partial class F26ReviewForm : Form
    {
        public F26ReviewForm()
        {
            InitializeComponent();
        }


        int GetRandomFrom(int max, int min = 0)
        {
            Random randy = new Random();
            return randy.Next(min, max + 1);
        }

        void DrawLine(int x, int y)
        {
            Graphics g = DrawPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.FromArgb(255, GetRandomFrom(255, 0), GetRandomFrom(255, 0), GetRandomFrom(255, 0)),3);
            g.DrawLine(thePen, 0, 0, x, y);

            thePen.Dispose();
            g.Dispose();
        }

        void DrawDart(int x, int y)
        {
            int diameter = GetRandomFrom(100, 0);
            int radius = diameter/2;
            int size = 10;
            Graphics g = DrawPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Black,GetRandomFrom(10,0));


            g.DrawLine(thePen, x - size, y, x + size, y); // Make the crosshair X plane
            g.DrawLine(thePen, x, y - size, x, y + size); // Makethe crosshair Y plane
            g.DrawEllipse(thePen, x - radius, y - radius, diameter, diameter); // Draw the circle at quards

            thePen.Dispose();
            g.Dispose();
        }

        // Event Handlers Below Here---------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawPictureBox_Click(object sender, EventArgs e)
        {
            int y = GetRandomFrom(DrawPictureBox.Height);
            int x = GetRandomFrom(DrawPictureBox.Width);

            DrawLine(x,y);
            DrawDart(x,y);
        }
    }
}
