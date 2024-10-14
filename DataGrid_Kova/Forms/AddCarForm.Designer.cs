namespace DataGrid_Kova.Forms
{
    partial class AddCarForm
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
            AddBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            brandcomboBox = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            ExitBtn.Location = new Point(165, 295);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(70, 57);
            ExitBtn.TabIndex = 8;
            ExitBtn.UseVisualStyleBackColor = false;
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
            AddBtn.Location = new Point(12, 295);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(120, 57);
            AddBtn.TabIndex = 9;
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 10;
            label1.Text = "ADD CAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Car brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "State number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Mileage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 14;
            label5.Text = "Current fuel volume";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 241);
            label6.Name = "label6";
            label6.Size = new Size(101, 35);
            label6.TabIndex = 15;
            label6.Text = "Rental price (per minute)";
            // 
            // brandcomboBox
            // 
            brandcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brandcomboBox.FormattingEnabled = true;
            brandcomboBox.Location = new Point(136, 69);
            brandcomboBox.Name = "brandcomboBox";
            brandcomboBox.Size = new Size(100, 23);
            brandcomboBox.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_2;
            CancelButton = AddBtn;
            ClientSize = new Size(248, 367);
            ControlBox = false;
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(brandcomboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddBtn);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitBtn;
        private Button AddBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox brandcomboBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}