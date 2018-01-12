namespace LibraryOneSystems_FINAL
{
    partial class BOARD_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOARD_student));
            this.titleLbl = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.backToMain = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.courseFld = new System.Windows.Forms.TextBox();
            this.idFld = new System.Windows.Forms.TextBox();
            this.nameFld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(776, 94);
            this.titleLbl.TabIndex = 38;
            this.titleLbl.Text = "Welcome to Library One";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secLbl
            // 
            this.secLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.secLbl.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(863, 395);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(125, 63);
            this.secLbl.TabIndex = 39;
            this.secLbl.Text = "10";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.backIcon;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 410);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(230, 44);
            this.backBtn.TabIndex = 54;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backToMain
            // 
            this.backToMain.Enabled = true;
            this.backToMain.Interval = 1000;
            this.backToMain.Tick += new System.EventHandler(this.backToMain_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.courseFld);
            this.panel4.Controls.Add(this.idFld);
            this.panel4.Controls.Add(this.nameFld);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.courseLbl);
            this.panel4.Controls.Add(this.idLbl);
            this.panel4.Controls.Add(this.nameLbl);
            this.panel4.Location = new System.Drawing.Point(22, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 252);
            this.panel4.TabIndex = 56;
            // 
            // courseFld
            // 
            this.courseFld.Enabled = false;
            this.courseFld.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseFld.Location = new System.Drawing.Point(205, 196);
            this.courseFld.Name = "courseFld";
            this.courseFld.Size = new System.Drawing.Size(250, 27);
            this.courseFld.TabIndex = 29;
            this.courseFld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idFld
            // 
            this.idFld.Enabled = false;
            this.idFld.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFld.Location = new System.Drawing.Point(205, 138);
            this.idFld.Name = "idFld";
            this.idFld.Size = new System.Drawing.Size(250, 27);
            this.idFld.TabIndex = 29;
            this.idFld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameFld
            // 
            this.nameFld.Enabled = false;
            this.nameFld.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFld.Location = new System.Drawing.Point(205, 82);
            this.nameFld.Name = "nameFld";
            this.nameFld.Size = new System.Drawing.Size(250, 27);
            this.nameFld.TabIndex = 28;
            this.nameFld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "Student Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseLbl
            // 
            this.courseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.courseLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.Location = new System.Drawing.Point(29, 196);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(170, 27);
            this.courseLbl.TabIndex = 26;
            this.courseLbl.Text = "COURSE";
            this.courseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLbl
            // 
            this.idLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(29, 138);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(170, 27);
            this.idLbl.TabIndex = 25;
            this.idLbl.Text = "STUDENT NUMBER";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(29, 82);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(170, 27);
            this.nameLbl.TabIndex = 24;
            this.nameLbl.Text = "FULL NAME ";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bookView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(506, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 252);
            this.panel1.TabIndex = 57;
            // 
            // bookView
            // 
            this.bookView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.bookView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookView.FullRowSelect = true;
            this.bookView.GridLines = true;
            this.bookView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bookView.Location = new System.Drawing.Point(25, 82);
            this.bookView.MultiSelect = false;
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(421, 141);
            this.bookView.TabIndex = 59;
            this.bookView.UseCompatibleStateImageBehavior = false;
            this.bookView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Title";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Return Date";
            this.columnHeader2.Width = 199;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 44);
            this.label2.TabIndex = 58;
            this.label2.Text = "Book Borrowed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BOARD_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1000, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.secLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BOARD_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer backToMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox courseFld;
        private System.Windows.Forms.TextBox idFld;
        private System.Windows.Forms.TextBox nameFld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView bookView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
    }
}