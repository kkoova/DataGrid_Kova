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
            CostRentText = new TextBox();
            addBtn = new Button();
            exBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 10;
            label1.Text = "ADD CAR";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 11;
            label2.Text = "Марка автомобиля";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 12;
            label3.Text = "Номер";
            // 
            // MileageText
            // 
            MileageText.AutoSize = true;
            MileageText.BackColor = Color.Transparent;
            MileageText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            MileageText.ForeColor = Color.White;
            MileageText.Location = new Point(12, 156);
            MileageText.Name = "MileageText";
            MileageText.Size = new Size(57, 15);
            MileageText.TabIndex = 13;
            MileageText.Text = "Пробег   ";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 14;
            label5.Text = "Объем топлива в баке";
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
            label6.Text = "Средний расход топлива";
            // 
            // brandcomboBox
            // 
            brandcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            brandcomboBox.FormattingEnabled = true;
            errorProvider.SetIconPadding(brandcomboBox, 2);
            brandcomboBox.Location = new Point(136, 69);
            brandcomboBox.Name = "brandcomboBox";
            brandcomboBox.Size = new Size(100, 23);
            brandcomboBox.TabIndex = 16;
            // 
            // StateNumberText
            // 
            errorProvider.SetIconPadding(StateNumberText, 2);
            StateNumberText.Location = new Point(136, 110);
            StateNumberText.Name = "StateNumberText";
            StateNumberText.PlaceholderText = "A123BC";
            StateNumberText.Size = new Size(100, 23);
            StateNumberText.TabIndex = 17;
            // 
            // MillText
            // 
            errorProvider.SetIconPadding(MillText, 2);
            MillText.Location = new Point(136, 153);
            MillText.Name = "MillText";
            MillText.PlaceholderText = "15000";
            MillText.Size = new Size(100, 23);
            MillText.TabIndex = 18;
            // 
            // CurrentFuelVolumeText
            // 
            errorProvider.SetIconPadding(CurrentFuelVolumeText, 2);
            CurrentFuelVolumeText.Location = new Point(136, 195);
            CurrentFuelVolumeText.Name = "CurrentFuelVolumeText";
            CurrentFuelVolumeText.PlaceholderText = "7.5";
            CurrentFuelVolumeText.Size = new Size(100, 23);
            CurrentFuelVolumeText.TabIndex = 19;
            // 
            // RentalPriceText
            // 
            errorProvider.SetIconPadding(RentalPriceText, 2);
            RentalPriceText.Location = new Point(135, 241);
            RentalPriceText.Name = "RentalPriceText";
            RentalPriceText.PlaceholderText = "50";
            RentalPriceText.Size = new Size(100, 23);
            RentalPriceText.TabIndex = 20;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // CostRentText
            // 
            errorProvider.SetIconPadding(CostRentText, 2);
            CostRentText.Location = new Point(135, 285);
            CostRentText.Name = "CostRentText";
            CostRentText.PlaceholderText = "99.00";
            CostRentText.Size = new Size(100, 23);
            CostRentText.TabIndex = 24;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(89, 114, 244);
            addBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addBtn.ForeColor = SystemColors.ButtonFace;
            addBtn.Location = new Point(258, 69);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(101, 195);
            addBtn.TabIndex = 21;
            addBtn.Text = "Добавить машину";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // exBtn
            // 
            exBtn.BackColor = SystemColors.ActiveCaptionText;
            exBtn.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exBtn.ForeColor = SystemColors.ButtonHighlight;
            exBtn.Location = new Point(258, 285);
            exBtn.Name = "exBtn";
            exBtn.Size = new Size(101, 33);
            exBtn.TabIndex = 22;
            exBtn.Text = "Отмена";
            exBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 285);
            label4.Name = "label4";
            label4.Size = new Size(101, 33);
            label4.TabIndex = 23;
            label4.Text = "Стоимость аренды";
            // 
            // AddCarForm
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_2;
            CancelButton = exBtn;
            ClientSize = new Size(371, 327);
            ControlBox = false;
            Controls.Add(CostRentText);
            Controls.Add(label4);
            Controls.Add(exBtn);
            Controls.Add(addBtn);
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
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button addBtn;
        private Button exBtn;
        private Label label4;
        private TextBox CostRentText;
    }
}
