namespace DataGridD
{
    partial class CarCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AverageFuelConsumptionText = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            FuelVolumeText = new Label();
            CostRentText = new Label();
            FuelReserveText = new Label();
            editButton = new Button();
            RentalAmountText = new Label();
            label1 = new Label();
            MileageText = new Label();
            NomerText = new Label();
            CarbrandText = new Label();
            CarPictBox = new PictureBox();
            dellbtn = new Button();
            AverageFueText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarPictBox).BeginInit();
            SuspendLayout();
            // 
            // AverageFuelConsumptionText
            // 
            AverageFuelConsumptionText.AutoSize = true;
            AverageFuelConsumptionText.ForeColor = SystemColors.AppWorkspace;
            AverageFuelConsumptionText.Location = new Point(112, 87);
            AverageFuelConsumptionText.Name = "AverageFuelConsumptionText";
            AverageFuelConsumptionText.Size = new Size(0, 15);
            AverageFuelConsumptionText.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 87);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 28;
            label5.Text = "Toplivo v hora:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fuel_pump;
            pictureBox3.Location = new Point(23, 201);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(113, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.oil;
            pictureBox1.Location = new Point(201, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // FuelVolumeText
            // 
            FuelVolumeText.ForeColor = SystemColors.AppWorkspace;
            FuelVolumeText.Location = new Point(46, 201);
            FuelVolumeText.Name = "FuelVolumeText";
            FuelVolumeText.Size = new Size(36, 15);
            FuelVolumeText.TabIndex = 24;
            FuelVolumeText.Text = "22";
            // 
            // CostRentText
            // 
            CostRentText.ForeColor = SystemColors.AppWorkspace;
            CostRentText.Location = new Point(136, 201);
            CostRentText.Name = "CostRentText";
            CostRentText.Size = new Size(45, 15);
            CostRentText.TabIndex = 23;
            CostRentText.Text = "43";
            // 
            // FuelReserveText
            // 
            FuelReserveText.ForeColor = SystemColors.AppWorkspace;
            FuelReserveText.Location = new Point(224, 201);
            FuelReserveText.Name = "FuelReserveText";
            FuelReserveText.Size = new Size(41, 15);
            FuelReserveText.TabIndex = 22;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Transparent;
            editButton.BackgroundImage = Properties.Resources.Edit;
            editButton.BackgroundImageLayout = ImageLayout.Stretch;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Location = new Point(146, 241);
            editButton.Name = "editButton";
            editButton.Size = new Size(86, 27);
            editButton.TabIndex = 21;
            editButton.UseVisualStyleBackColor = false;
            // 
            // RentalAmountText
            // 
            RentalAmountText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            RentalAmountText.Location = new Point(23, 247);
            RentalAmountText.Name = "RentalAmountText";
            RentalAmountText.Size = new Size(103, 21);
            RentalAmountText.TabIndex = 20;
            RentalAmountText.Text = "5456 rub";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 66);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 19;
            label1.Text = "Probeg:";
            // 
            // MileageText
            // 
            MileageText.AutoSize = true;
            MileageText.ForeColor = SystemColors.AppWorkspace;
            MileageText.Location = new Point(76, 66);
            MileageText.Name = "MileageText";
            MileageText.Size = new Size(63, 15);
            MileageText.TabIndex = 18;
            MileageText.Text = "754 543km";
            // 
            // NomerText
            // 
            NomerText.AutoSize = true;
            NomerText.ForeColor = SystemColors.AppWorkspace;
            NomerText.Location = new Point(23, 34);
            NomerText.Name = "NomerText";
            NomerText.Size = new Size(44, 15);
            NomerText.TabIndex = 17;
            NomerText.Text = "yr 3324";
            // 
            // CarbrandText
            // 
            CarbrandText.AutoSize = true;
            CarbrandText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CarbrandText.Location = new Point(23, 19);
            CarbrandText.Name = "CarbrandText";
            CarbrandText.Size = new Size(32, 15);
            CarbrandText.TabIndex = 16;
            CarbrandText.Text = "CAR";
            // 
            // CarPictBox
            // 
            CarPictBox.Location = new Point(23, 105);
            CarPictBox.Name = "CarPictBox";
            CarPictBox.Size = new Size(242, 90);
            CarPictBox.SizeMode = PictureBoxSizeMode.Zoom;
            CarPictBox.TabIndex = 15;
            CarPictBox.TabStop = false;
            // 
            // dellbtn
            // 
            dellbtn.BackColor = Color.Transparent;
            dellbtn.BackgroundImage = Properties.Resources.Delit;
            dellbtn.BackgroundImageLayout = ImageLayout.Stretch;
            dellbtn.FlatAppearance.BorderSize = 0;
            dellbtn.FlatStyle = FlatStyle.Popup;
            dellbtn.Location = new Point(238, 241);
            dellbtn.Name = "dellbtn";
            dellbtn.Size = new Size(27, 27);
            dellbtn.TabIndex = 30;
            dellbtn.UseVisualStyleBackColor = false;
            // 
            // AverageFueText
            // 
            AverageFueText.AutoSize = true;
            AverageFueText.ForeColor = SystemColors.AppWorkspace;
            AverageFueText.Location = new Point(112, 87);
            AverageFueText.Name = "AverageFueText";
            AverageFueText.Size = new Size(63, 15);
            AverageFueText.TabIndex = 31;
            AverageFueText.Text = "754 543km";
            // 
            // CarCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(AverageFueText);
            Controls.Add(dellbtn);
            Controls.Add(AverageFuelConsumptionText);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(FuelVolumeText);
            Controls.Add(CostRentText);
            Controls.Add(FuelReserveText);
            Controls.Add(editButton);
            Controls.Add(RentalAmountText);
            Controls.Add(label1);
            Controls.Add(MileageText);
            Controls.Add(NomerText);
            Controls.Add(CarbrandText);
            Controls.Add(CarPictBox);
            Name = "CarCard";
            Size = new Size(293, 286);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarPictBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AverageFuelConsumptionText;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label FuelVolumeText;
        private Label CostRentText;
        private Label FuelReserveText;
        private Button editButton;
        private Label RentalAmountText;
        private Label label1;
        private Label MileageText;
        private Label NomerText;
        private Label CarbrandText;
        private PictureBox CarPictBox;
        private Button dellbtn;
        private Label AverageFueText;
    }
}
