using System.Drawing;
using System.Windows.Forms;

namespace DataGridD
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
            this.ViewAllCarsBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllCarsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAllCarsBtn
            // 
            this.ViewAllCarsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewAllCarsBtn.BackgroundImage = global::DataGridCar.Properties.Resources.goBtn;
            this.ViewAllCarsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewAllCarsBtn.Location = new System.Drawing.Point(280, 426);
            this.ViewAllCarsBtn.Name = "ViewAllCarsBtn";
            this.ViewAllCarsBtn.Size = new System.Drawing.Size(597, 123);
            this.ViewAllCarsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ViewAllCarsBtn.TabIndex = 0;
            this.ViewAllCarsBtn.TabStop = false;
            this.ViewAllCarsBtn.Click += new System.EventHandler(this.ViewAllCarsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = global::DataGridCar.Properties.Resources.Group_2;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(1062, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(72, 55);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGridCar.Properties.Resources.Frame_1;
            this.ClientSize = new System.Drawing.Size(1155, 871);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ViewAllCarsBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllCarsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ViewAllCarsBtn;
        private PictureBox ExitBtn;
    }
}
