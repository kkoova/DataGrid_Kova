namespace DataGrid_Kova
{
    partial class MainForm
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
            ViewAllCarsBtn = new PictureBox();
            ExitBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ViewAllCarsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            SuspendLayout();
            // 
            // ViewAllCarsBtn
            // 
            ViewAllCarsBtn.BackColor = Color.Transparent;
            ViewAllCarsBtn.BackgroundImage = Properties.Resources.Group_1__1_;
            ViewAllCarsBtn.Cursor = Cursors.Hand;
            ViewAllCarsBtn.Location = new Point(295, 425);
            ViewAllCarsBtn.Name = "ViewAllCarsBtn";
            ViewAllCarsBtn.Size = new Size(597, 142);
            ViewAllCarsBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            ViewAllCarsBtn.TabIndex = 0;
            ViewAllCarsBtn.TabStop = false;
            ViewAllCarsBtn.Click += ViewAllCarsBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Image = Properties.Resources.Group_2;
            ExitBtn.Location = new Point(1046, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(100, 50);
            ExitBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            ExitBtn.TabIndex = 1;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1;
            ClientSize = new Size(1158, 912);
            ControlBox = false;
            Controls.Add(ExitBtn);
            Controls.Add(ViewAllCarsBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)ViewAllCarsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ViewAllCarsBtn;
        private PictureBox ExitBtn;
    }
}
