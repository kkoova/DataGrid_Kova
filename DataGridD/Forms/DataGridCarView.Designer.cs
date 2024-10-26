namespace DataGridD.Forms
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
            flowLayoutPanel = new FlowLayoutPanel();
            exBtn = new Button();
            AddBtn = new Button();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            AllAvto = new ToolStripStatusLabel();
            FluelLow = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Location = new Point(12, 75);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(615, 800);
            flowLayoutPanel.TabIndex = 6;
            // 
            // exBtn
            // 
            exBtn.BackColor = Color.Black;
            exBtn.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exBtn.ForeColor = SystemColors.ButtonFace;
            exBtn.Location = new Point(525, 12);
            exBtn.Name = "exBtn";
            exBtn.Size = new Size(101, 46);
            exBtn.TabIndex = 24;
            exBtn.Text = "Выйти";
            exBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(89, 114, 244);
            AddBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddBtn.ForeColor = SystemColors.ButtonFace;
            AddBtn.Location = new Point(327, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(178, 46);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Добавить машину";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 25;
            label1.Text = "АвтоПрокат";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { AllAvto, FluelLow });
            statusStrip1.Location = new Point(0, 892);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(638, 22);
            statusStrip1.TabIndex = 26;
            statusStrip1.Text = "statusStrip1";
            // 
            // AllAvto
            // 
            AllAvto.Name = "AllAvto";
            AllAvto.Size = new Size(118, 17);
            AllAvto.Text = "toolStripStatusLabel1";
            // 
            // FluelLow
            // 
            FluelLow.Name = "FluelLow";
            FluelLow.Size = new Size(118, 17);
            FluelLow.Text = "toolStripStatusLabel1";
            // 
            // DataGridCarView
            // 
            AcceptButton = AddBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 181, 249);
            CancelButton = exBtn;
            ClientSize = new Size(638, 914);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(exBtn);
            Controls.Add(AddBtn);
            Controls.Add(flowLayoutPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataGridCarView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DataGridCarView_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel;
        private Button exBtn;
        private Button AddBtn;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel AllAvto;
        private ToolStripStatusLabel FluelLow;
    }
}
