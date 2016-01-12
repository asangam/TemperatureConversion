namespace TemperatureConversion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pnlTemperature = new System.Windows.Forms.Panel();
            this.lblConverted2 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblConverted1 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.cmbTemperatures = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Conversion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.pnlTemperature);
            this.groupBox1.Controls.Add(this.cmbTemperatures);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTemperature);
            this.groupBox1.Location = new System.Drawing.Point(42, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Details";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Firebrick;
            this.btnConvert.Location = new System.Drawing.Point(40, 88);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 33);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pnlTemperature
            // 
            this.pnlTemperature.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTemperature.Controls.Add(this.lblConverted2);
            this.pnlTemperature.Controls.Add(this.lblTemp2);
            this.pnlTemperature.Controls.Add(this.lblConverted1);
            this.pnlTemperature.Controls.Add(this.lblTemp1);
            this.pnlTemperature.Location = new System.Drawing.Point(16, 127);
            this.pnlTemperature.Name = "pnlTemperature";
            this.pnlTemperature.Size = new System.Drawing.Size(515, 181);
            this.pnlTemperature.TabIndex = 3;
            this.pnlTemperature.Visible = false;
            // 
            // lblConverted2
            // 
            this.lblConverted2.AutoSize = true;
            this.lblConverted2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverted2.Location = new System.Drawing.Point(219, 79);
            this.lblConverted2.Name = "lblConverted2";
            this.lblConverted2.Size = new System.Drawing.Size(80, 28);
            this.lblConverted2.TabIndex = 3;
            this.lblConverted2.Text = "label5";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp2.Location = new System.Drawing.Point(31, 79);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(80, 28);
            this.lblTemp2.TabIndex = 2;
            this.lblTemp2.Text = "label6";
            // 
            // lblConverted1
            // 
            this.lblConverted1.AutoSize = true;
            this.lblConverted1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverted1.Location = new System.Drawing.Point(219, 28);
            this.lblConverted1.Name = "lblConverted1";
            this.lblConverted1.Size = new System.Drawing.Size(80, 28);
            this.lblConverted1.TabIndex = 1;
            this.lblConverted1.Text = "label4";
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp1.Location = new System.Drawing.Point(31, 28);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(80, 28);
            this.lblTemp1.TabIndex = 0;
            this.lblTemp1.Text = "label3";
            // 
            // cmbTemperatures
            // 
            this.cmbTemperatures.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTemperatures.FormattingEnabled = true;
            this.cmbTemperatures.Items.AddRange(new object[] {
            "Celsius",
            "Farenheit",
            "Kelvin"});
            this.cmbTemperatures.Location = new System.Drawing.Point(393, 53);
            this.cmbTemperatures.Name = "cmbTemperatures";
            this.cmbTemperatures.Size = new System.Drawing.Size(124, 27);
            this.cmbTemperatures.TabIndex = 2;
            this.cmbTemperatures.SelectedIndexChanged += new System.EventHandler(this.cmbTemperatures_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTemperature.Location = new System.Drawing.Point(165, 54);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(207, 26);
            this.txtTemperature.TabIndex = 0;
            this.txtTemperature.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTemperature_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(598, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTemperature.ResumeLayout(false);
            this.pnlTemperature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel pnlTemperature;
        private System.Windows.Forms.Label lblConverted2;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblConverted1;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.ComboBox cmbTemperatures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperature;
    }
}

