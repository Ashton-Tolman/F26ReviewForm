namespace F26ReviewForm
{
    partial class F26ReviewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            DrawPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DrawPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(204, 343);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(109, 62);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DrawPictureBox
            // 
            DrawPictureBox.Location = new Point(12, 12);
            DrawPictureBox.Name = "DrawPictureBox";
            DrawPictureBox.Size = new Size(297, 325);
            DrawPictureBox.TabIndex = 1;
            DrawPictureBox.TabStop = false;
            DrawPictureBox.Click += DrawPictureBox_Click;
            // 
            // F26ReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 417);
            Controls.Add(DrawPictureBox);
            Controls.Add(ExitButton);
            Name = "F26ReviewForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DrawPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private PictureBox DrawPictureBox;
    }
}
