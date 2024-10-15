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
            AddBtn = new Button();
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
            // AddBtn
            // 
            AddBtn.BackColor = Color.Transparent;
            AddBtn.BackgroundImage = Properties.Resources.ADD;
            AddBtn.BackgroundImageLayout = ImageLayout.Zoom;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBtn.ForeColor = Color.Transparent;
            AddBtn.Location = new Point(432, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(107, 57);
            AddBtn.TabIndex = 7;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DataGridCarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            CancelButton = ExitBtn;
            ClientSize = new Size(638, 914);
            ControlBox = false;
            Controls.Add(AddBtn);
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
        private Button AddBtn;
    }
}