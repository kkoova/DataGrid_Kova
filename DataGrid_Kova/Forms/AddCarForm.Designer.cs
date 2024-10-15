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
            components = new System.ComponentModel.Container();
            ExitBtn = new Button();
            AddBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MileageText = new Label();
            label5 = new Label();
            label6 = new Label();
            brandcomboBox = new ComboBox();
            StateNumberText = new TextBox();
            MillText = new TextBox();
            CurrentFuelVolumeText = new TextBox();
            RentalPriceText = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.BackgroundImage = Properties.Resources.Group_2;
            ExitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Segoe UI Light", 8.25F);
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
            AddBtn.Font = new Font("Segoe UI Light", 8.25F);
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
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
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
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
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
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "State number";
            // 
            // MileageText
            // 
            MileageText.AutoSize = true;
            MileageText.BackColor = Color.Transparent;
            MileageText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            MileageText.ForeColor = Color.White;
            MileageText.Location = new Point(12, 156);
            MileageText.Name = "MileageText";
            MileageText.Size = new Size(49, 15);
            MileageText.TabIndex = 13;
            MileageText.Text = "Mileage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
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
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
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
            // StateNumberText
            // 
            StateNumberText.Location = new Point(136, 110);
            StateNumberText.Name = "StateNumberText";
            StateNumberText.Size = new Size(100, 23);
            StateNumberText.TabIndex = 17;
            // 
            // MillText
            // 
            MillText.Location = new Point(136, 153);
            MillText.Name = "MillText";
            MillText.Size = new Size(100, 23);
            MillText.TabIndex = 18;
            // 
            // CurrentFuelVolumeText
            // 
            CurrentFuelVolumeText.Location = new Point(136, 195);
            CurrentFuelVolumeText.Name = "CurrentFuelVolumeText";
            CurrentFuelVolumeText.Size = new Size(100, 23);
            CurrentFuelVolumeText.TabIndex = 19;
            // 
            // RentalPriceText
            // 
            RentalPriceText.Location = new Point(135, 241);
            RentalPriceText.Name = "RentalPriceText";
            RentalPriceText.Size = new Size(100, 23);
            RentalPriceText.TabIndex = 20;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddCarForm
            // 
            AcceptButton = AddBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_2;
            CancelButton = ExitBtn;
            ClientSize = new Size(248, 367);
            ControlBox = false;
            Controls.Add(RentalPriceText);
            Controls.Add(CurrentFuelVolumeText);
            Controls.Add(MillText);
            Controls.Add(StateNumberText);
            Controls.Add(brandcomboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(MileageText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddBtn);
            Controls.Add(ExitBtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitBtn;
        private Button AddBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label MileageText;
        private Label label5;
        private Label label6;
        private ComboBox brandcomboBox;
        private TextBox StateNumberText;
        private TextBox MillText;
        private TextBox CurrentFuelVolumeText;
        private TextBox RentalPriceText;
        private ErrorProvider errorProvider;
    }
}