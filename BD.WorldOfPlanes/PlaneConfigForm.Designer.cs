namespace BD.WorldOfPlanes
{
    partial class PlaneConfigForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPlaneWithRadar = new System.Windows.Forms.Label();
            this.lPlane = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pColor8 = new System.Windows.Forms.Panel();
            this.pColor6 = new System.Windows.Forms.Panel();
            this.pColor7 = new System.Windows.Forms.Panel();
            this.pColor4 = new System.Windows.Forms.Panel();
            this.pColor5 = new System.Windows.Forms.Panel();
            this.pColor3 = new System.Windows.Forms.Panel();
            this.pColor2 = new System.Windows.Forms.Panel();
            this.pColor1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMoreEngine = new System.Windows.Forms.CheckBox();
            this.cbHasRadar = new System.Windows.Forms.CheckBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bCreatePlane = new System.Windows.Forms.Button();
            this.lDopColor = new System.Windows.Forms.Label();
            this.pPictureBox = new System.Windows.Forms.Panel();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            this.lMainColor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.pPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPlaneWithRadar);
            this.groupBox1.Controls.Add(this.lPlane);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолета";
            // 
            // lPlaneWithRadar
            // 
            this.lPlaneWithRadar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPlaneWithRadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlaneWithRadar.Location = new System.Drawing.Point(9, 87);
            this.lPlaneWithRadar.Name = "lPlaneWithRadar";
            this.lPlaneWithRadar.Size = new System.Drawing.Size(176, 45);
            this.lPlaneWithRadar.TabIndex = 1;
            this.lPlaneWithRadar.Text = "Самолет с радаром";
            this.lPlaneWithRadar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPlaneWithRadar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lPlaneWithRadar_MouseDown);
            // 
            // lPlane
            // 
            this.lPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPlane.Location = new System.Drawing.Point(10, 32);
            this.lPlane.Name = "lPlane";
            this.lPlane.Size = new System.Drawing.Size(176, 45);
            this.lPlane.TabIndex = 0;
            this.lPlane.Text = "Самолет";
            this.lPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lPlane_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pColor8);
            this.groupBox2.Controls.Add(this.pColor6);
            this.groupBox2.Controls.Add(this.pColor7);
            this.groupBox2.Controls.Add(this.pColor4);
            this.groupBox2.Controls.Add(this.pColor5);
            this.groupBox2.Controls.Add(this.pColor3);
            this.groupBox2.Controls.Add(this.pColor2);
            this.groupBox2.Controls.Add(this.pColor1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(577, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Палитра";
            // 
            // pColor8
            // 
            this.pColor8.BackColor = System.Drawing.Color.Fuchsia;
            this.pColor8.Location = new System.Drawing.Point(90, 208);
            this.pColor8.Name = "pColor8";
            this.pColor8.Size = new System.Drawing.Size(69, 52);
            this.pColor8.TabIndex = 6;
            // 
            // pColor6
            // 
            this.pColor6.BackColor = System.Drawing.Color.Aqua;
            this.pColor6.Location = new System.Drawing.Point(90, 150);
            this.pColor6.Name = "pColor6";
            this.pColor6.Size = new System.Drawing.Size(69, 52);
            this.pColor6.TabIndex = 6;
            // 
            // pColor7
            // 
            this.pColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pColor7.Location = new System.Drawing.Point(15, 208);
            this.pColor7.Name = "pColor7";
            this.pColor7.Size = new System.Drawing.Size(69, 52);
            this.pColor7.TabIndex = 5;
            // 
            // pColor4
            // 
            this.pColor4.BackColor = System.Drawing.Color.Yellow;
            this.pColor4.Location = new System.Drawing.Point(90, 90);
            this.pColor4.Name = "pColor4";
            this.pColor4.Size = new System.Drawing.Size(69, 52);
            this.pColor4.TabIndex = 6;
            // 
            // pColor5
            // 
            this.pColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pColor5.Location = new System.Drawing.Point(15, 150);
            this.pColor5.Name = "pColor5";
            this.pColor5.Size = new System.Drawing.Size(69, 52);
            this.pColor5.TabIndex = 5;
            // 
            // pColor3
            // 
            this.pColor3.BackColor = System.Drawing.Color.Red;
            this.pColor3.Location = new System.Drawing.Point(15, 90);
            this.pColor3.Name = "pColor3";
            this.pColor3.Size = new System.Drawing.Size(69, 52);
            this.pColor3.TabIndex = 5;
            // 
            // pColor2
            // 
            this.pColor2.BackColor = System.Drawing.Color.Black;
            this.pColor2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pColor2.Location = new System.Drawing.Point(90, 32);
            this.pColor2.Name = "pColor2";
            this.pColor2.Size = new System.Drawing.Size(69, 52);
            this.pColor2.TabIndex = 4;
            // 
            // pColor1
            // 
            this.pColor1.BackColor = System.Drawing.Color.White;
            this.pColor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pColor1.Location = new System.Drawing.Point(15, 32);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(69, 52);
            this.pColor1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMoreEngine);
            this.groupBox4.Controls.Add(this.cbHasRadar);
            this.groupBox4.Controls.Add(this.nudWeight);
            this.groupBox4.Controls.Add(this.nudSpeed);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 159);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры";
            // 
            // cbMoreEngine
            // 
            this.cbMoreEngine.AutoSize = true;
            this.cbMoreEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMoreEngine.Location = new System.Drawing.Point(9, 101);
            this.cbMoreEngine.Name = "cbMoreEngine";
            this.cbMoreEngine.Size = new System.Drawing.Size(138, 22);
            this.cbMoreEngine.TabIndex = 7;
            this.cbMoreEngine.Text = "Доп. двигатели";
            this.cbMoreEngine.UseVisualStyleBackColor = true;
            // 
            // cbHasRadar
            // 
            this.cbHasRadar.AutoSize = true;
            this.cbHasRadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbHasRadar.Location = new System.Drawing.Point(9, 129);
            this.cbHasRadar.Name = "cbHasRadar";
            this.cbHasRadar.Size = new System.Drawing.Size(168, 22);
            this.cbHasRadar.TabIndex = 6;
            this.cbHasRadar.Text = "Авиационный радар";
            this.cbHasRadar.UseVisualStyleBackColor = true;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(131, 64);
            this.nudWeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(54, 23);
            this.nudWeight.TabIndex = 5;
            this.nudWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(131, 35);
            this.nudSpeed.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(54, 23);
            this.nudSpeed.TabIndex = 4;
            this.nudSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Макс. скорость: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Масса: ";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(577, 333);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(168, 36);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "ОТМЕНА";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bCreatePlane
            // 
            this.bCreatePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreatePlane.Location = new System.Drawing.Point(577, 287);
            this.bCreatePlane.Name = "bCreatePlane";
            this.bCreatePlane.Size = new System.Drawing.Size(168, 40);
            this.bCreatePlane.TabIndex = 4;
            this.bCreatePlane.Text = "СОЗДАТЬ";
            this.bCreatePlane.UseVisualStyleBackColor = true;
            this.bCreatePlane.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // lDopColor
            // 
            this.lDopColor.AllowDrop = true;
            this.lDopColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDopColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDopColor.Location = new System.Drawing.Point(224, 22);
            this.lDopColor.Name = "lDopColor";
            this.lDopColor.Size = new System.Drawing.Size(169, 58);
            this.lDopColor.TabIndex = 2;
            this.lDopColor.Text = "Доп. цвет";
            this.lDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.lDopColor_DragDrop);
            this.lDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.lColor_DragEnter);
            // 
            // pPictureBox
            // 
            this.pPictureBox.AllowDrop = true;
            this.pPictureBox.Controls.Add(this.pbConfig);
            this.pPictureBox.Location = new System.Drawing.Point(221, 99);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(350, 270);
            this.pPictureBox.TabIndex = 5;
            this.pPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pPictureBox_DragDrop);
            this.pPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pPictureBox_DragEnter);
            // 
            // pbConfig
            // 
            this.pbConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbConfig.Location = new System.Drawing.Point(3, 3);
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.Size = new System.Drawing.Size(332, 264);
            this.pbConfig.TabIndex = 0;
            this.pbConfig.TabStop = false;
            // 
            // lMainColor
            // 
            this.lMainColor.AllowDrop = true;
            this.lMainColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMainColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMainColor.Location = new System.Drawing.Point(399, 22);
            this.lMainColor.Name = "lMainColor";
            this.lMainColor.Size = new System.Drawing.Size(163, 58);
            this.lMainColor.TabIndex = 1;
            this.lMainColor.Text = "Основной цвет";
            this.lMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.lMainColor_DragDrop);
            this.lMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.lColor_DragEnter);
            // 
            // PlaneConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 379);
            this.Controls.Add(this.lMainColor);
            this.Controls.Add(this.lDopColor);
            this.Controls.Add(this.pPictureBox);
            this.Controls.Add(this.bCreatePlane);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlaneConfigForm";
            this.Text = "Конфигурация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.pPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPlaneWithRadar;
        private System.Windows.Forms.Label lPlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbMoreEngine;
        private System.Windows.Forms.CheckBox cbHasRadar;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bCreatePlane;
        private System.Windows.Forms.Panel pColor8;
        private System.Windows.Forms.Panel pColor6;
        private System.Windows.Forms.Panel pColor7;
        private System.Windows.Forms.Panel pColor4;
        private System.Windows.Forms.Panel pColor5;
        private System.Windows.Forms.Panel pColor3;
        private System.Windows.Forms.Panel pColor2;
        private System.Windows.Forms.Panel pColor1;
        private System.Windows.Forms.Label lDopColor;
        private System.Windows.Forms.Panel pPictureBox;
        private System.Windows.Forms.PictureBox pbConfig;
        private System.Windows.Forms.Label lMainColor;
    }
}