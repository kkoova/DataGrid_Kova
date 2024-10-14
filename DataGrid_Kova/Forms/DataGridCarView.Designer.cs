namespace DataGrid_Kova.Forms
{
    partial class DataGridCarView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitBtn = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.BackgroundImage = Properties.Resources.Group_2;
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBtn.ForeColor = Color.Transparent;
            ExitBtn.Location = new Point(1064, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(82, 57);
            ExitBtn.TabIndex = 3;
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.car_1;
            pictureBox1.Location = new Point(613, 715);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Location = new Point(12, 128);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1134, 708);
            flowLayoutPanel.TabIndex = 6;
            // 
            // DataGridCarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_2;
            CancelButton = ExitBtn;
            ClientSize = new Size(1158, 959);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataGridCarView";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitBtn;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel;
    }
}