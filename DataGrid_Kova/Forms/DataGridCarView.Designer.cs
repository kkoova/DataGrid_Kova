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
            flowLayoutPanel = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.BackgroundImage = Properties.Resources.Group_2;
            ExitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBtn.ForeColor = Color.Transparent;
            ExitBtn.Location = new Point(545, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(82, 57);
            ExitBtn.TabIndex = 3;
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click_1;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Location = new Point(12, 75);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(615, 827);
            flowLayoutPanel.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.ADD;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(432, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 57);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DataGridCarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            CancelButton = ExitBtn;
            ClientSize = new Size(638, 914);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataGridCarView";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button ExitBtn;
        private FlowLayoutPanel flowLayoutPanel;
        private Button button1;
    }
}