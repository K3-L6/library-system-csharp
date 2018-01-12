namespace LibraryOneSystems_FINAL
{
    partial class REGISTER_librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTER_librarian));
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.emailFld = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minOUT = new System.Windows.Forms.NumericUpDown();
            this.hrsOUT = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minIN = new System.Windows.Forms.NumericUpDown();
            this.hrsIN = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rpassFld = new System.Windows.Forms.TextBox();
            this.passFld = new System.Windows.Forms.TextBox();
            this.userFld = new System.Windows.Forms.TextBox();
            this.firstFld = new System.Windows.Forms.TextBox();
            this.lastFld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsIN)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 10);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(687, 77);
            this.titleLbl.TabIndex = 45;
            this.titleLbl.Text = "Librarian Registration Form";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.emailFld);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.minOUT);
            this.panel4.Controls.Add(this.hrsOUT);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.minIN);
            this.panel4.Controls.Add(this.hrsIN);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rpassFld);
            this.panel4.Controls.Add(this.passFld);
            this.panel4.Controls.Add(this.userFld);
            this.panel4.Controls.Add(this.firstFld);
            this.panel4.Controls.Add(this.lastFld);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(213, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 477);
            this.panel4.TabIndex = 46;
            // 
            // emailFld
            // 
            this.emailFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailFld.Location = new System.Drawing.Point(371, 299);
            this.emailFld.Name = "emailFld";
            this.emailFld.Size = new System.Drawing.Size(316, 31);
            this.emailFld.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 31);
            this.label8.TabIndex = 78;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOUT
            // 
            this.minOUT.BackColor = System.Drawing.Color.White;
            this.minOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minOUT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOUT.Location = new System.Drawing.Point(485, 416);
            this.minOUT.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minOUT.Name = "minOUT";
            this.minOUT.ReadOnly = true;
            this.minOUT.Size = new System.Drawing.Size(75, 27);
            this.minOUT.TabIndex = 10;
            this.minOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minOUT.ValueChanged += new System.EventHandler(this.minOUT_ValueChanged);
            // 
            // hrsOUT
            // 
            this.hrsOUT.BackColor = System.Drawing.Color.White;
            this.hrsOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrsOUT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsOUT.Location = new System.Drawing.Point(404, 417);
            this.hrsOUT.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hrsOUT.Name = "hrsOUT";
            this.hrsOUT.ReadOnly = true;
            this.hrsOUT.Size = new System.Drawing.Size(75, 27);
            this.hrsOUT.TabIndex = 9;
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
            this.label6.Location = new System.Drawing.Point(258, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 75;
            this.label6.Text = "Time OUT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minIN
            // 
            this.minIN.BackColor = System.Drawing.Color.White;
            this.minIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minIN.Location = new System.Drawing.Point(485, 364);
            this.minIN.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minIN.Name = "minIN";
            this.minIN.ReadOnly = true;
            this.minIN.Size = new System.Drawing.Size(75, 27);
            this.minIN.TabIndex = 8;
            this.minIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minIN.ValueChanged += new System.EventHandler(this.minIN_ValueChanged);
            // 
            // hrsIN
            // 
            this.hrsIN.BackColor = System.Drawing.Color.White;
            this.hrsIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrsIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsIN.Location = new System.Drawing.Point(404, 365);
            this.hrsIN.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hrsIN.Name = "hrsIN";
            this.hrsIN.ReadOnly = true;
            this.hrsIN.Size = new System.Drawing.Size(75, 27);
            this.hrsIN.TabIndex = 7;
            this.hrsIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hrsIN.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hrsIN.ValueChanged += new System.EventHandler(this.hrsIN_ValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 31);
            this.label5.TabIndex = 72;
            this.label5.Text = "Time IN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpassFld
            // 
            this.rpassFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpassFld.Location = new System.Drawing.Point(371, 249);
            this.rpassFld.Name = "rpassFld";
            this.rpassFld.PasswordChar = '*';
            this.rpassFld.Size = new System.Drawing.Size(316, 31);
            this.rpassFld.TabIndex = 5;
            // 
            // passFld
            // 
            this.passFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passFld.Location = new System.Drawing.Point(371, 199);
            this.passFld.Name = "passFld";
            this.passFld.PasswordChar = '*';
            this.passFld.Size = new System.Drawing.Size(316, 31);
            this.passFld.TabIndex = 4;
            // 
            // userFld
            // 
            this.userFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFld.Location = new System.Drawing.Point(371, 149);
            this.userFld.Name = "userFld";
            this.userFld.Size = new System.Drawing.Size(316, 31);
            this.userFld.TabIndex = 3;
            // 
            // firstFld
            // 
            this.firstFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFld.Location = new System.Drawing.Point(371, 99);
            this.firstFld.Name = "firstFld";
            this.firstFld.Size = new System.Drawing.Size(316, 31);
            this.firstFld.TabIndex = 2;
            // 
            // lastFld
            // 
            this.lastFld.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFld.Location = new System.Drawing.Point(371, 46);
            this.lastFld.Name = "lastFld";
            this.lastFld.Size = new System.Drawing.Size(316, 31);
            this.lastFld.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 31);
            this.label7.TabIndex = 66;
            this.label7.Text = "Repeat Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 34);
            this.label3.TabIndex = 64;
            this.label3.Text = "Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 62;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.saveIcon;
            this.regBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regBtn.Location = new System.Drawing.Point(952, 615);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(230, 44);
            this.regBtn.TabIndex = 11;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.backIcon;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 616);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(230, 44);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // REGISTER_librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1194, 671);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "REGISTER_librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrsIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox emailFld;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown minOUT;
        private System.Windows.Forms.NumericUpDown hrsOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minIN;
        private System.Windows.Forms.NumericUpDown hrsIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rpassFld;
        private System.Windows.Forms.TextBox passFld;
        private System.Windows.Forms.TextBox userFld;
        private System.Windows.Forms.TextBox firstFld;
        private System.Windows.Forms.TextBox lastFld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button backBtn;
    }
}