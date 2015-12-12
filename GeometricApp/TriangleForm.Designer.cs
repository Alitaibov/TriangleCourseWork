namespace GeometricApp
{
    partial class TriangleForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.AddHight_Button = new System.Windows.Forms.Button();
            this.AddMedian_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBisector_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AB_Side_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AreaTextbox = new System.Windows.Forms.TextBox();
            this.PerimetrTextbox = new System.Windows.Forms.TextBox();
            this.sides_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.AC_Side_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.BC_Side_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.ACB_Angle_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.ABC_Angle_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.BAC_Angle_textBox = new System.Windows.Forms.TextBox();
            this.Redraw_Button = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.sideName_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.sides_flowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(12, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(549, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Вписанная окружность";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(549, 34);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(145, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Описанная окружность";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // AddHight_Button
            // 
            this.AddHight_Button.Location = new System.Drawing.Point(385, 54);
            this.AddHight_Button.Name = "AddHight_Button";
            this.AddHight_Button.Size = new System.Drawing.Size(138, 23);
            this.AddHight_Button.TabIndex = 5;
            this.AddHight_Button.Text = "Добавить высоту";
            this.AddHight_Button.UseVisualStyleBackColor = true;
            this.AddHight_Button.Click += new System.EventHandler(this.AddHight_Button_Click);
            // 
            // AddMedian_Button
            // 
            this.AddMedian_Button.Location = new System.Drawing.Point(385, 84);
            this.AddMedian_Button.Name = "AddMedian_Button";
            this.AddMedian_Button.Size = new System.Drawing.Size(138, 23);
            this.AddMedian_Button.TabIndex = 6;
            this.AddMedian_Button.Text = "Добавить медиану";
            this.AddMedian_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "К какой стороне";
            // 
            // AddBisector_Button
            // 
            this.AddBisector_Button.Location = new System.Drawing.Point(385, 113);
            this.AddBisector_Button.Name = "AddBisector_Button";
            this.AddBisector_Button.Size = new System.Drawing.Size(138, 23);
            this.AddBisector_Button.TabIndex = 10;
            this.AddBisector_Button.Text = "Добавить биссектрису";
            this.AddBisector_Button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Длины отрезков:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "AB=";
            // 
            // AB_Side_textBox
            // 
            this.AB_Side_textBox.Location = new System.Drawing.Point(49, 3);
            this.AB_Side_textBox.Name = "AB_Side_textBox";
            this.AB_Side_textBox.Size = new System.Drawing.Size(100, 20);
            this.AB_Side_textBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Углы:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "S=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "P=";
            // 
            // AreaTextbox
            // 
            this.AreaTextbox.Location = new System.Drawing.Point(572, 86);
            this.AreaTextbox.Name = "AreaTextbox";
            this.AreaTextbox.Size = new System.Drawing.Size(53, 20);
            this.AreaTextbox.TabIndex = 30;
            // 
            // PerimetrTextbox
            // 
            this.PerimetrTextbox.Location = new System.Drawing.Point(571, 61);
            this.PerimetrTextbox.Name = "PerimetrTextbox";
            this.PerimetrTextbox.Size = new System.Drawing.Size(54, 20);
            this.PerimetrTextbox.TabIndex = 29;
            // 
            // sides_flowLayoutPanel
            // 
            this.sides_flowLayoutPanel.AutoScroll = true;
            this.sides_flowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.sides_flowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.sides_flowLayoutPanel.Controls.Add(this.flowLayoutPanel3);
            this.sides_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sides_flowLayoutPanel.Location = new System.Drawing.Point(385, 195);
            this.sides_flowLayoutPanel.Name = "sides_flowLayoutPanel";
            this.sides_flowLayoutPanel.Size = new System.Drawing.Size(189, 169);
            this.sides_flowLayoutPanel.TabIndex = 33;
            this.sides_flowLayoutPanel.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.AB_Side_textBox);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 28);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.AC_Side_textBox);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(155, 28);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "AC=";
            // 
            // AC_Side_textBox
            // 
            this.AC_Side_textBox.Location = new System.Drawing.Point(49, 3);
            this.AC_Side_textBox.Name = "AC_Side_textBox";
            this.AC_Side_textBox.Size = new System.Drawing.Size(100, 20);
            this.AC_Side_textBox.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label13);
            this.flowLayoutPanel3.Controls.Add(this.BC_Side_textBox);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(155, 28);
            this.flowLayoutPanel3.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "BC=";
            // 
            // BC_Side_textBox
            // 
            this.BC_Side_textBox.Location = new System.Drawing.Point(49, 3);
            this.BC_Side_textBox.Name = "BC_Side_textBox";
            this.BC_Side_textBox.Size = new System.Drawing.Size(100, 20);
            this.BC_Side_textBox.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(580, 195);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(205, 169);
            this.flowLayoutPanel4.TabIndex = 36;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label14);
            this.flowLayoutPanel5.Controls.Add(this.ACB_Angle_textBox);
            this.flowLayoutPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(172, 28);
            this.flowLayoutPanel5.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "ACB=";
            // 
            // ACB_Angle_textBox
            // 
            this.ACB_Angle_textBox.Location = new System.Drawing.Point(60, 3);
            this.ACB_Angle_textBox.Name = "ACB_Angle_textBox";
            this.ACB_Angle_textBox.Size = new System.Drawing.Size(100, 20);
            this.ACB_Angle_textBox.TabIndex = 15;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label15);
            this.flowLayoutPanel6.Controls.Add(this.ABC_Angle_textBox);
            this.flowLayoutPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(172, 28);
            this.flowLayoutPanel6.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "ABC=";
            // 
            // ABC_Angle_textBox
            // 
            this.ABC_Angle_textBox.Location = new System.Drawing.Point(60, 3);
            this.ABC_Angle_textBox.Name = "ABC_Angle_textBox";
            this.ABC_Angle_textBox.Size = new System.Drawing.Size(100, 20);
            this.ABC_Angle_textBox.TabIndex = 15;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label16);
            this.flowLayoutPanel7.Controls.Add(this.BAC_Angle_textBox);
            this.flowLayoutPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(172, 28);
            this.flowLayoutPanel7.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "BAC=";
            // 
            // BAC_Angle_textBox
            // 
            this.BAC_Angle_textBox.Location = new System.Drawing.Point(60, 3);
            this.BAC_Angle_textBox.Name = "BAC_Angle_textBox";
            this.BAC_Angle_textBox.Size = new System.Drawing.Size(102, 20);
            this.BAC_Angle_textBox.TabIndex = 15;
            // 
            // Redraw_Button
            // 
            this.Redraw_Button.Location = new System.Drawing.Point(410, 153);
            this.Redraw_Button.Name = "Redraw_Button";
            this.Redraw_Button.Size = new System.Drawing.Size(88, 23);
            this.Redraw_Button.TabIndex = 37;
            this.Redraw_Button.Text = "Перерисовать";
            this.Redraw_Button.UseVisualStyleBackColor = true;
            this.Redraw_Button.Click += new System.EventHandler(this.Redraw_Button_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(629, 153);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(88, 23);
            this.Calculate.TabIndex = 38;
            this.Calculate.Text = "Посчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // sideName_comboBox
            // 
            this.sideName_comboBox.FormattingEnabled = true;
            this.sideName_comboBox.Items.AddRange(new object[] {
            "AB",
            "AC",
            "BC"});
            this.sideName_comboBox.Location = new System.Drawing.Point(388, 28);
            this.sideName_comboBox.Name = "sideName_comboBox";
            this.sideName_comboBox.Size = new System.Drawing.Size(121, 21);
            this.sideName_comboBox.TabIndex = 39;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 375);
            this.Controls.Add(this.sideName_comboBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Redraw_Button);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sides_flowLayoutPanel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AreaTextbox);
            this.Controls.Add(this.PerimetrTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddBisector_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddMedian_Button);
            this.Controls.Add(this.AddHight_Button);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pictureBox);
            this.Name = "TriangleForm";
            this.Text = "Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.sides_flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button AddHight_Button;
        private System.Windows.Forms.Button AddMedian_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBisector_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AB_Side_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AreaTextbox;
        private System.Windows.Forms.TextBox PerimetrTextbox;
        private System.Windows.Forms.FlowLayoutPanel sides_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AC_Side_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BC_Side_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ACB_Angle_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ABC_Angle_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BAC_Angle_textBox;
        private System.Windows.Forms.Button Redraw_Button;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ComboBox sideName_comboBox;
    }
}

