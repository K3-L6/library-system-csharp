namespace LibraryOneSystems_FINAL
{
    partial class PRINT_userLog_form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINT_userLog_form));
            this.tbl_studentLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LibraryDataDataSet1 = new LibraryOneSystems_FINAL.LibraryDataDataSet1();
            this.titleLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_studentLogTableAdapter = new LibraryOneSystems_FINAL.LibraryDataDataSet1TableAdapters.tbl_studentLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_studentLogBindingSource
            // 
            this.tbl_studentLogBindingSource.DataMember = "tbl_studentLog";
            this.tbl_studentLogBindingSource.DataSource = this.LibraryDataDataSet1;
            // 
            // LibraryDataDataSet1
            // 
            this.LibraryDataDataSet1.DataSetName = "LibraryDataDataSet1";
            this.LibraryDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(574, 77);
            this.titleLbl.TabIndex = 40;
            this.titleLbl.Text = "Student Log Report";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::LibraryOneSystems_FINAL.Properties.Resources.backIcon;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(592, 25);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(190, 44);
            this.backBtn.TabIndex = 57;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_studentLogBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryOneSystems_FINAL.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(56, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(683, 347);
            this.reportViewer1.TabIndex = 58;
            // 
            // tbl_studentLogTableAdapter
            // 
            this.tbl_studentLogTableAdapter.ClearBeforeFill = true;
            // 
            // PRINT_userLog_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(794, 471);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PRINT_userLog_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PRINT_userLog_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button backBtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_studentLogBindingSource;
        private LibraryDataDataSet1 LibraryDataDataSet1;
        private LibraryDataDataSet1TableAdapters.tbl_studentLogTableAdapter tbl_studentLogTableAdapter;
    }
}