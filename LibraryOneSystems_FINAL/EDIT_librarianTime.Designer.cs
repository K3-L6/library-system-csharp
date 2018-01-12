namespace LibraryOneSystems_FINAL
{
    partial class EDIT_librarianTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDIT_librarianTime));
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minOUT = new System.Windows.Forms.NumericUpDown();
            this.hrsOUT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minIN = new System.Windows.Forms.NumericUpDown();
            this.hrsIN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.oldTImeOut = new System.Windows.Forms.Label();
            this.oldTimeIN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsIN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.updateIcon;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(352, 515);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(230, 44);
            this.updateBtn.TabIndex = 70;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.backIcon;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 515);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(230, 44);
            this.backBtn.TabIndex = 71;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.minOUT);
            this.panel2.Controls.Add(this.hrsOUT);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.minIN);
            this.panel2.Controls.Add(this.hrsIN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(91, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 119);
            this.panel2.TabIndex = 77;
            // 
            // minOUT
            // 
            this.minOUT.BackColor = System.Drawing.Color.White;
            this.minOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minOUT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOUT.Location = new System.Drawing.Point(282, 75);
            this.minOUT.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minOUT.Name = "minOUT";
            this.minOUT.ReadOnly = true;
            this.minOUT.Size = new System.Drawing.Size(75, 27);
            this.minOUT.TabIndex = 67;
            this.minOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minOUT.ValueChanged += new System.EventHandler(this.minOUT_ValueChanged);
            // 
            // hrsOUT
            // 
            this.hrsOUT.BackColor = System.Drawing.Color.White;
            this.hrsOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrsOUT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsOUT.Location = new System.Drawing.Point(201, 76);
            this.hrsOUT.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hrsOUT.Name = "hrsOUT";
            this.hrsOUT.ReadOnly = true;
            this.hrsOUT.Size = new System.Drawing.Size(75, 27);
            this.hrsOUT.TabIndex = 66;
            this.hrsOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hrsOUT.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hrsOUT.ValueChanged += new System.EventHandler(this.hrsOUT_ValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 65;
            this.label6.Text = "Time OUT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minIN
            // 
            this.minIN.BackColor = System.Drawing.Color.White;
            this.minIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minIN.Location = new System.Drawing.Point(282, 23);
            this.minIN.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minIN.Name = "minIN";
            this.minIN.ReadOnly = true;
            this.minIN.Size = new System.Drawing.Size(75, 27);
            this.minIN.TabIndex = 63;
            this.minIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minIN.ValueChanged += new System.EventHandler(this.minIN_ValueChanged);
            // 
            // hrsIN
            // 
            this.hrsIN.BackColor = System.Drawing.Color.White;
            this.hrsIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrsIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsIN.Location = new System.Drawing.Point(201, 24);
            this.hrsIN.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hrsIN.Name = "hrsIN";
            this.hrsIN.ReadOnly = true;
            this.hrsIN.Size = new System.Drawing.Size(75, 27);
            this.hrsIN.TabIndex = 62;
            this.hrsIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hrsIN.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hrsIN.ValueChanged += new System.EventHandler(this.hrsIN_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Time IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.oldTImeOut);
            this.panel1.Controls.Add(this.oldTimeIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(74, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 119);
            this.panel1.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 35);
            this.label5.TabIndex = 21;
            this.label5.Text = "TO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldTImeOut
            // 
            this.oldTImeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.oldTImeOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldTImeOut.Location = new System.Drawing.Point(291, 62);
            this.oldTImeOut.Name = "oldTImeOut";
            this.oldTImeOut.Size = new System.Drawing.Size(130, 35);
            this.oldTImeOut.TabIndex = 20;
            this.oldTImeOut.Text = "TimeOUT";
            this.oldTImeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldTimeIN
            // 
            this.oldTimeIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.oldTimeIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldTimeIN.Location = new System.Drawing.Point(35, 62);
            this.oldTimeIN.Name = "oldTimeIN";
            this.oldTimeIN.Size = new System.Drawing.Size(130, 35);
            this.oldTimeIN.TabIndex = 19;
            this.oldTimeIN.Text = "TimeIN";
            this.oldTimeIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Current Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.nameLbl);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(74, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 115);
            this.panel6.TabIndex = 75;
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(35, 61);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(386, 33);
            this.nameLbl.TabIndex = 19;
            this.nameLbl.Text = "Full Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Librarian Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EDIT_librarianTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(594, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EDIT_librarianTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsIN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown minOUT;
        private System.Windows.Forms.NumericUpDown hrsOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minIN;
        private System.Windows.Forms.NumericUpDown hrsIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label oldTImeOut;
        private System.Windows.Forms.Label oldTimeIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label2;
    }
}