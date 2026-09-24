namespace F26ReviewForm
{
    public partial class F26ReviewForm : Form
    {
        public F26ReviewForm()
        {
            InitializeComponent();
            DrawLine();
        }

        void DrawLine()
        {
            MessageBox.Show("BIG BEATDOWN COMIN UP");
        }

        // Event Handlers Below Here---------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawPictureBox_Click(object sender, EventArgs e)
        {
            DrawLine();
        }
    }
}
