namespace LibraryOneSystems_FINAL
{
    partial class SETTINGS_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETTINGS_admin));
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteRecordsPnl = new System.Windows.Forms.Panel();
            this.deleteRecordsBtn = new System.Windows.Forms.Button();
            this.librarianTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.libView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabView = new System.Windows.Forms.TabControl();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.aedPanel = new System.Windows.Forms.Panel();
            this.updateTimeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.deleteRecordsPnl.SuspendLayout();
            this.librarianTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TabView.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.aedPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 10);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(574, 77);
            this.titleLbl.TabIndex = 52;
            this.titleLbl.Text = "Admin Settings";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.changeBtn);
            this.panel3.Location = new System.Drawing.Point(536, 589);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 71);
            this.panel3.TabIndex = 56;
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.infoChangeIcon;
            this.changeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeBtn.Location = new System.Drawing.Point(16, 14);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(271, 40);
            this.changeBtn.TabIndex = 40;
            this.changeBtn.Text = "Change Admin Info";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.nameLbl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(593, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 104);
            this.panel4.TabIndex = 61;
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(27, 52);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(375, 33);
            this.nameLbl.TabIndex = 19;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Admin Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.dateLbl);
            this.panel6.Controls.Add(this.timeLbl);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(862, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 195);
            this.panel6.TabIndex = 60;
            // 
            // dateLbl
            // 
            this.dateLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(35, 123);
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
            this.timeLbl.Location = new System.Drawing.Point(35, 61);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(239, 33);
            this.timeLbl.TabIndex = 19;
            this.timeLbl.Text = "Time";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time OUT";
            this.columnHeader5.Width = 180;
            // 
            // deleteRecordsPnl
            // 
            this.deleteRecordsPnl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.deleteRecordsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteRecordsPnl.Controls.Add(this.deleteRecordsBtn);
            this.deleteRecordsPnl.Location = new System.Drawing.Point(40, 588);
            this.deleteRecordsPnl.Name = "deleteRecordsPnl";
            this.deleteRecordsPnl.Size = new System.Drawing.Size(490, 71);
            this.deleteRecordsPnl.TabIndex = 54;
            this.deleteRecordsPnl.Visible = false;
            // 
            // deleteRecordsBtn
            // 
            this.deleteRecordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteRecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecordsBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordsBtn.ForeColor = System.Drawing.Color.White;
            this.deleteRecordsBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.allDeleteIcon;
            this.deleteRecordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteRecordsBtn.Location = new System.Drawing.Point(26, 15);
            this.deleteRecordsBtn.Name = "deleteRecordsBtn";
            this.deleteRecordsBtn.Size = new System.Drawing.Size(437, 40);
            this.deleteRecordsBtn.TabIndex = 42;
            this.deleteRecordsBtn.Text = "DELETE RECORDS";
            this.deleteRecordsBtn.UseVisualStyleBackColor = false;
            this.deleteRecordsBtn.Click += new System.EventHandler(this.deleteRecordsBtn_Click);
            // 
            // librarianTab
            // 
            this.librarianTab.Controls.Add(this.panel5);
            this.librarianTab.Location = new System.Drawing.Point(4, 33);
            this.librarianTab.Name = "librarianTab";
            this.librarianTab.Padding = new System.Windows.Forms.Padding(3);
            this.librarianTab.Size = new System.Drawing.Size(792, 452);
            this.librarianTab.TabIndex = 5;
            this.librarianTab.Text = "Librarian Info";
            this.librarianTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.libView);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(780, 440);
            this.panel5.TabIndex = 9;
            // 
            // libView
            // 
            this.libView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.libView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.libView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libView.FullRowSelect = true;
            this.libView.GridLines = true;
            this.libView.Location = new System.Drawing.Point(3, 3);
            this.libView.MultiSelect = false;
            this.libView.Name = "libView";
            this.libView.Size = new System.Drawing.Size(774, 434);
            this.libView.TabIndex = 4;
            this.libView.UseCompatibleStateImageBehavior = false;
            this.libView.View = System.Windows.Forms.View.Details;
            this.libView.SelectedIndexChanged += new System.EventHandler(this.libView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Username";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Last Name";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "First Name";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Time IN";
            this.columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Time OUT";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Email";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time IN";
            this.columnHeader4.Width = 180;
            // 
            // TabView
            // 
            this.TabView.AllowDrop = true;
            this.TabView.Controls.Add(this.librarianTab);
            this.TabView.Controls.Add(this.historyTab);
            this.TabView.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabView.Location = new System.Drawing.Point(40, 90);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(800, 489);
            this.TabView.TabIndex = 55;
            this.TabView.SelectedIndexChanged += new System.EventHandler(this.TabView_SelectedIndexChanged);
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.panel2);
            this.historyTab.Location = new System.Drawing.Point(4, 33);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(792, 452);
            this.historyTab.TabIndex = 6;
            this.historyTab.Text = "Librarian Records";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.logView);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 440);
            this.panel2.TabIndex = 10;
            // 
            // logView
            // 
            this.logView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.logView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logView.FullRowSelect = true;
            this.logView.GridLines = true;
            this.logView.Location = new System.Drawing.Point(3, 3);
            this.logView.MultiSelect = false;
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(774, 434);
            this.logView.TabIndex = 4;
            this.logView.UseCompatibleStateImageBehavior = false;
            this.logView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 181;
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            // 
            // aedPanel
            // 
            this.aedPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.aedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aedPanel.Controls.Add(this.updateTimeBtn);
            this.aedPanel.Controls.Add(this.deleteBtn);
            this.aedPanel.Controls.Add(this.addtn);
            this.aedPanel.Location = new System.Drawing.Point(40, 588);
            this.aedPanel.Name = "aedPanel";
            this.aedPanel.Size = new System.Drawing.Size(490, 71);
            this.aedPanel.TabIndex = 64;
            // 
            // updateTimeBtn
            // 
            this.updateTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTimeBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTimeBtn.ForeColor = System.Drawing.Color.White;
            this.updateTimeBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.updateTimeIcon;
            this.updateTimeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateTimeBtn.Location = new System.Drawing.Point(326, 15);
            this.updateTimeBtn.Name = "updateTimeBtn";
            this.updateTimeBtn.Size = new System.Drawing.Size(150, 40);
            this.updateTimeBtn.TabIndex = 13;
            this.updateTimeBtn.Text = "UPDATE";
            this.updateTimeBtn.UseVisualStyleBackColor = false;
            this.updateTimeBtn.Click += new System.EventHandler(this.updateTimeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.deleteIcon;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(170, 15);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 40);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addtn
            // 
            this.addtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtn.ForeColor = System.Drawing.Color.White;
            this.addtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.addIcon;
            this.addtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addtn.Location = new System.Drawing.Point(14, 15);
            this.addtn.Name = "addtn";
            this.addtn.Size = new System.Drawing.Size(150, 40);
            this.addtn.TabIndex = 11;
            this.addtn.Text = "ADD";
            this.addtn.UseVisualStyleBackColor = false;
            this.addtn.Click += new System.EventHandler(this.addtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(1043, 73);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(142, 44);
            this.logOutBtn.TabIndex = 63;
            this.logOutBtn.Text = "    Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.backIcon;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(1043, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(142, 44);
            this.backBtn.TabIndex = 62;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.label11);
            this.searchPanel.Controls.Add(this.searchKey);
            this.searchPanel.Location = new System.Drawing.Point(862, 161);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(304, 163);
            this.searchPanel.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Keyword";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 38);
            this.label11.TabIndex = 21;
            this.label11.Text = "Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchKey
            // 
            this.searchKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKey.Location = new System.Drawing.Point(23, 96);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(250, 27);
            this.searchKey.TabIndex = 20;
            this.searchKey.TextChanged += new System.EventHandler(this.searchKey_TextChanged);
            // 
            // SETTINGS_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1194, 671);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.aedPanel);
            this.Controls.Add(this.deleteRecordsPnl);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TabView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SETTINGS_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.deleteRecordsPnl.ResumeLayout(false);
            this.librarianTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.TabView.ResumeLayout(false);
            this.historyTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.aedPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteRecordsBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel deleteRecordsPnl;
        private System.Windows.Forms.TabPage librarianTab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView libView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView logView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer currentTime;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel aedPanel;
        private System.Windows.Forms.Button updateTimeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addtn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchKey;
    }
}