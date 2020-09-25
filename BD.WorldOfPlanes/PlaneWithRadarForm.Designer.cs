using System;

namespace BD.WorldOfPlanes
{
    partial class PlaneWithRadarForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaneWithRadarForm));
            this.bMoveUp = new System.Windows.Forms.Button();
            this.bMoveDown = new System.Windows.Forms.Button();
            this.bMoveRight = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.bMoveLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // bMoveUp
            // 
            this.bMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMoveUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMoveUp.BackgroundImage")));
            this.bMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMoveUp.Location = new System.Drawing.Point(1106, 515);
            this.bMoveUp.Margin = new System.Windows.Forms.Padding(0);
            this.bMoveUp.Name = "bMoveUp";
            this.bMoveUp.Size = new System.Drawing.Size(60, 60);
            this.bMoveUp.TabIndex = 0;
            this.bMoveUp.UseMnemonic = false;
            this.bMoveUp.UseVisualStyleBackColor = true;
            this.bMoveUp.Click += new System.EventHandler(this.bMove_click);
            // 
            // bMoveDown
            // 
            this.bMoveDown.AllowDrop = true;
            this.bMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMoveDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMoveDown.BackgroundImage")));
            this.bMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMoveDown.Location = new System.Drawing.Point(1106, 590);
            this.bMoveDown.Margin = new System.Windows.Forms.Padding(0);
            this.bMoveDown.Name = "bMoveDown";
            this.bMoveDown.Size = new System.Drawing.Size(60, 60);
            this.bMoveDown.TabIndex = 2;
            this.bMoveDown.UseMnemonic = false;
            this.bMoveDown.UseVisualStyleBackColor = true;
            this.bMoveDown.Click += new System.EventHandler(this.bMove_click);
            // 
            // bMoveRight
            // 
            this.bMoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMoveRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMoveRight.BackgroundImage")));
            this.bMoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMoveRight.Location = new System.Drawing.Point(1183, 590);
            this.bMoveRight.Margin = new System.Windows.Forms.Padding(0);
            this.bMoveRight.Name = "bMoveRight";
            this.bMoveRight.Size = new System.Drawing.Size(60, 60);
            this.bMoveRight.TabIndex = 3;
            this.bMoveRight.UseMnemonic = false;
            this.bMoveRight.UseVisualStyleBackColor = true;
            this.bMoveRight.Click += new System.EventHandler(this.bMove_click);
            // 
            // bStart
            // 
            this.bStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStart.Location = new System.Drawing.Point(1064, 51);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(133, 41);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlane.BackColor = System.Drawing.Color.Beige;
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(23, 26);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(962, 624);
            this.pictureBoxPlane.TabIndex = 5;
            this.pictureBoxPlane.TabStop = false;
            // 
            // bMoveLeft
            // 
            this.bMoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMoveLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMoveLeft.BackgroundImage")));
            this.bMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMoveLeft.Location = new System.Drawing.Point(1026, 590);
            this.bMoveLeft.Margin = new System.Windows.Forms.Padding(0);
            this.bMoveLeft.Name = "bMoveLeft";
            this.bMoveLeft.Size = new System.Drawing.Size(60, 60);
            this.bMoveLeft.TabIndex = 6;
            this.bMoveLeft.UseMnemonic = false;
            this.bMoveLeft.UseVisualStyleBackColor = true;
            this.bMoveLeft.Click += new System.EventHandler(this.bMove_click);
            // 
            // PlaneWithRadarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 672);
            this.Controls.Add(this.bMoveLeft);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bMoveRight);
            this.Controls.Add(this.bMoveDown);
            this.Controls.Add(this.bMoveUp);
            this.Controls.Add(this.pictureBoxPlane);
            this.Name = "PlaneWithRadarForm";
            this.Text = "World of Planes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button bMoveUp;
        private System.Windows.Forms.Button bMoveDown;
        private System.Windows.Forms.Button bMoveRight;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Button bMoveLeft;
    }
}

