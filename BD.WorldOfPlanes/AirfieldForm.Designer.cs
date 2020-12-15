namespace BD.WorldOfPlanes
{
    partial class AirfieldForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.bCreateNewAirfield = new System.Windows.Forms.Button();
            this.bDeleteAirfield = new System.Windows.Forms.Button();
            this.tbNewAirfieldName = new System.Windows.Forms.TextBox();
            this.lbExistingAirfields = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTakePlane = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSetPlane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            this.fdOpen = new System.Windows.Forms.OpenFileDialog();
            this.bSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxAircraft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bSort);
            this.splitContainer1.Panel2.Controls.Add(this.bCreateNewAirfield);
            this.splitContainer1.Panel2.Controls.Add(this.bDeleteAirfield);
            this.splitContainer1.Panel2.Controls.Add(this.tbNewAirfieldName);
            this.splitContainer1.Panel2.Controls.Add(this.lbExistingAirfields);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.bSetPlane);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 632);
            this.splitContainer1.SplitterDistance = 994;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAircraft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(990, 628);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // bCreateNewAirfield
            // 
            this.bCreateNewAirfield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateNewAirfield.Location = new System.Drawing.Point(17, 50);
            this.bCreateNewAirfield.Name = "bCreateNewAirfield";
            this.bCreateNewAirfield.Size = new System.Drawing.Size(227, 50);
            this.bCreateNewAirfield.TabIndex = 6;
            this.bCreateNewAirfield.Text = "Добавить аэродром";
            this.bCreateNewAirfield.UseVisualStyleBackColor = true;
            this.bCreateNewAirfield.Click += new System.EventHandler(this.bCreateNewAirfield_Click);
            // 
            // bDeleteAirfield
            // 
            this.bDeleteAirfield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteAirfield.Location = new System.Drawing.Point(17, 306);
            this.bDeleteAirfield.Name = "bDeleteAirfield";
            this.bDeleteAirfield.Size = new System.Drawing.Size(227, 50);
            this.bDeleteAirfield.TabIndex = 5;
            this.bDeleteAirfield.Text = "Удалить аэропорт";
            this.bDeleteAirfield.UseVisualStyleBackColor = true;
            this.bDeleteAirfield.Click += new System.EventHandler(this.bDeleteAirfield_Click);
            // 
            // tbNewAirfieldName
            // 
            this.tbNewAirfieldName.Location = new System.Drawing.Point(17, 22);
            this.tbNewAirfieldName.Name = "tbNewAirfieldName";
            this.tbNewAirfieldName.Size = new System.Drawing.Size(227, 22);
            this.tbNewAirfieldName.TabIndex = 4;
            // 
            // lbExistingAirfields
            // 
            this.lbExistingAirfields.FormattingEnabled = true;
            this.lbExistingAirfields.ItemHeight = 16;
            this.lbExistingAirfields.Location = new System.Drawing.Point(17, 152);
            this.lbExistingAirfields.Name = "lbExistingAirfields";
            this.lbExistingAirfields.Size = new System.Drawing.Size(227, 148);
            this.lbExistingAirfields.TabIndex = 3;
            this.lbExistingAirfields.SelectedIndexChanged += new System.EventHandler(this.lbExistingAirfields_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bTakePlane);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bTakePlane
            // 
            this.bTakePlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTakePlane.Location = new System.Drawing.Point(6, 87);
            this.bTakePlane.Name = "bTakePlane";
            this.bTakePlane.Size = new System.Drawing.Size(221, 45);
            this.bTakePlane.TabIndex = 3;
            this.bTakePlane.Text = "Take";
            this.bTakePlane.UseVisualStyleBackColor = true;
            this.bTakePlane.Click += new System.EventHandler(this.bTakePlane_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место: ";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox.Location = new System.Drawing.Point(87, 45);
            this.maskedTextBox.Mask = "0";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(29, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать самолет";
            // 
            // bSetPlane
            // 
            this.bSetPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSetPlane.Location = new System.Drawing.Point(17, 365);
            this.bSetPlane.Name = "bSetPlane";
            this.bSetPlane.Size = new System.Drawing.Size(227, 50);
            this.bSetPlane.TabIndex = 0;
            this.bSetPlane.Text = "Посадить самолет";
            this.bSetPlane.UseVisualStyleBackColor = true;
            this.bSetPlane.Click += new System.EventHandler(this.bSetPlane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // fdSave
            // 
            this.fdSave.Filter = "txt file | *.txt";
            // 
            // fdOpen
            // 
            this.fdOpen.FileName = "openFileDialog1";
            this.fdOpen.Filter = "txt file | *.txt";
            // 
            // bSort
            // 
            this.bSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSort.Location = new System.Drawing.Point(17, 421);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(227, 50);
            this.bSort.TabIndex = 7;
            this.bSort.Text = "Сортировать";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // AirfieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AirfieldForm";
            this.Text = "Аэропорт";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.Button bSetPlane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button bTakePlane;
        private System.Windows.Forms.Button bCreateNewAirfield;
        private System.Windows.Forms.Button bDeleteAirfield;
        private System.Windows.Forms.TextBox tbNewAirfieldName;
        private System.Windows.Forms.ListBox lbExistingAirfields;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog fdSave;
        private System.Windows.Forms.OpenFileDialog fdOpen;
        private System.Windows.Forms.Button bSort;
    }
}