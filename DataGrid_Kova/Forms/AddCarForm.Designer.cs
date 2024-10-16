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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MileageText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brandcomboBox = new System.Windows.Forms.ComboBox();
            this.StateNumberText = new System.Windows.Forms.TextBox();
            this.MillText = new System.Windows.Forms.TextBox();
            this.CurrentFuelVolumeText = new System.Windows.Forms.TextBox();
            this.RentalPriceText = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.exBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CostRentText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ADD CAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Car brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "State number";
            // 
            // MileageText
            // 
            this.MileageText.AutoSize = true;
            this.MileageText.BackColor = System.Drawing.Color.Transparent;
            this.MileageText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MileageText.ForeColor = System.Drawing.Color.White;
            this.MileageText.Location = new System.Drawing.Point(12, 156);
            this.MileageText.Name = "MileageText";
            this.MileageText.Size = new System.Drawing.Size(49, 15);
            this.MileageText.TabIndex = 13;
            this.MileageText.Text = "Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current fuel volume";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rental price (per minute)";
            // 
            // brandcomboBox
            // 
            this.brandcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandcomboBox.FormattingEnabled = true;
            this.brandcomboBox.Location = new System.Drawing.Point(136, 69);
            this.brandcomboBox.Name = "brandcomboBox";
            this.brandcomboBox.Size = new System.Drawing.Size(100, 23);
            this.brandcomboBox.TabIndex = 16;
            // 
            // StateNumberText
            // 
            this.StateNumberText.Location = new System.Drawing.Point(136, 110);
            this.StateNumberText.Name = "StateNumberText";
            this.StateNumberText.Size = new System.Drawing.Size(100, 23);
            this.StateNumberText.TabIndex = 17;
            // 
            // MillText
            // 
            this.MillText.Location = new System.Drawing.Point(136, 153);
            this.MillText.Name = "MillText";
            this.MillText.Size = new System.Drawing.Size(100, 23);
            this.MillText.TabIndex = 18;
            // 
            // CurrentFuelVolumeText
            // 
            this.CurrentFuelVolumeText.Location = new System.Drawing.Point(136, 195);
            this.CurrentFuelVolumeText.Name = "CurrentFuelVolumeText";
            this.CurrentFuelVolumeText.Size = new System.Drawing.Size(100, 23);
            this.CurrentFuelVolumeText.TabIndex = 19;
            // 
            // RentalPriceText
            // 
            this.RentalPriceText.Location = new System.Drawing.Point(135, 241);
            this.RentalPriceText.Name = "RentalPriceText";
            this.RentalPriceText.Size = new System.Drawing.Size(100, 23);
            this.RentalPriceText.TabIndex = 20;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Location = new System.Drawing.Point(258, 69);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 138);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "Добавить машину";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // exBtn
            // 
            this.exBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exBtn.Location = new System.Drawing.Point(258, 213);
            this.exBtn.Name = "exBtn";
            this.exBtn.Size = new System.Drawing.Size(101, 92);
            this.exBtn.TabIndex = 22;
            this.exBtn.Text = "Отмена";
            this.exBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cost Rent";
            // 
            // CostRentText
            // 
            this.CostRentText.Location = new System.Drawing.Point(135, 282);
            this.CostRentText.Name = "CostRentText";
            this.CostRentText.Size = new System.Drawing.Size(100, 23);
            this.CostRentText.TabIndex = 24;
            // 
            // AddCarForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGrid_Kova.Properties.Resources.Frame_2;
            this.CancelButton = this.exBtn;
            this.ClientSize = new System.Drawing.Size(371, 320);
            this.ControlBox = false;
            this.Controls.Add(this.CostRentText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.RentalPriceText);
            this.Controls.Add(this.CurrentFuelVolumeText);
            this.Controls.Add(this.MillText);
            this.Controls.Add(this.StateNumberText);
            this.Controls.Add(this.brandcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MileageText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
