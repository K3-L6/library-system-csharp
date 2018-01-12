namespace LibraryOneSystems_FINAL
{
    partial class LOGIN_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.passFld = new System.Windows.Forms.TextBox();
            this.userFld = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.backToMainTM = new System.Windows.Forms.Timer(this.components);
            this.resetPassBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.passFld);
            this.panel1.Controls.Add(this.userFld);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(310, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 283);
            this.panel1.TabIndex = 35;
            // 
            // passFld
            // 
            this.passFld.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passFld.Location = new System.Drawing.Point(213, 156);
            this.passFld.Name = "passFld";
            this.passFld.PasswordChar = '*';
            this.passFld.Size = new System.Drawing.Size(319, 37);
            this.passFld.TabIndex = 9;
            this.passFld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userFld
            // 
            this.userFld.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFld.Location = new System.Drawing.Point(213, 89);
            this.userFld.Name = "userFld";
            this.userFld.Size = new System.Drawing.Size(319, 37);
            this.userFld.TabIndex = 8;
            this.userFld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.dateLbl);
            this.panel4.Controls.Add(this.timeLbl);
            this.panel4.Location = new System.Drawing.Point(12, 527);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 132);
            this.panel4.TabIndex = 39;
            // 
            // dateLbl
            // 
            this.dateLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(35, 73);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(239, 33);
            this.dateLbl.TabIndex = 20;
            this.dateLbl.Text = "Date";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(35, 22);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(239, 33);
            this.timeLbl.TabIndex = 19;
            this.timeLbl.Text = "Time";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // backToMainTM
            // 
            this.backToMainTM.Enabled = true;
            this.backToMainTM.Interval = 1000;
            this.backToMainTM.Tick += new System.EventHandler(this.backToMainTM_Tick);
            // 
            // resetPassBtn
            // 
            this.resetPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resetPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPassBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassBtn.ForeColor = System.Drawing.Color.White;
            this.resetPassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetPassBtn.Location = new System.Drawing.Point(946, 607);
            this.resetPassBtn.Name = "resetPassBtn";
            this.resetPassBtn.Size = new System.Drawing.Size(236, 52);
            this.resetPassBtn.TabIndex = 40;
            this.resetPassBtn.Text = "Reset Password";
            this.resetPassBtn.UseVisualStyleBackColor = false;
            this.resetPassBtn.Visible = false;
            this.resetPassBtn.Click += new System.EventHandler(this.resetPassBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.loginIcon;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(648, 483);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(236, 52);
            this.loginBtn.TabIndex = 38;
            this.loginBtn.Text = "Log IN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::LibraryOneSystems_FINAL.Properties.Resources.passwordIcon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::LibraryOneSystems_FINAL.Properties.Resources.userIcon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "  Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Image = global::LibraryOneSystems_FINAL.Properties.Resources.MainIcon;
            this.titleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(930, 137);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "Library One System";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLbl.DoubleClick += new System.EventHandler(this.titleLbl_DoubleClick);
            // 
            // LOGIN_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1194, 671);
            this.Controls.Add(this.resetPassBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOGIN_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainLogin_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passFld;
        private System.Windows.Forms.TextBox userFld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer currentTime;
        private System.Windows.Forms.Timer backToMainTM;
        private System.Windows.Forms.Button resetPassBtn;
    }
}