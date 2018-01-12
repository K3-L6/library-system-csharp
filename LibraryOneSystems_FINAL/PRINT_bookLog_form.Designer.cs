namespace LibraryOneSystems_FINAL
{
    partial class PRINT_bookLog_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINT_bookLog_form));
            this.tbl_brLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LibraryDataDataSet = new LibraryOneSystems_FINAL.LibraryDataDataSet();
            this.titleLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.rpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_brLogTableAdapter = new LibraryOneSystems_FINAL.LibraryDataDataSetTableAdapters.tbl_brLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_brLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_brLogBindingSource
            // 
            this.tbl_brLogBindingSource.DataMember = "tbl_brLog";
            this.tbl_brLogBindingSource.DataSource = this.LibraryDataDataSet;
            // 
            // LibraryDataDataSet
            // 
            this.LibraryDataDataSet.DataSetName = "LibraryDataDataSet";
            this.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(574, 77);
            this.titleLbl.TabIndex = 39;
            this.titleLbl.Text = "Book Log Report";
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
            this.backBtn.Location = new System.Drawing.Point(592, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(190, 44);
            this.backBtn.TabIndex = 56;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // rpView
            // 
            this.rpView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_brLogBindingSource;
            this.rpView.LocalReport.DataSources.Add(reportDataSource1);
            this.rpView.LocalReport.ReportEmbeddedResource = "LibraryOneSystems_FINAL.Report2.rdlc";
            this.rpView.Location = new System.Drawing.Point(56, 100);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(683, 347);
            this.rpView.TabIndex = 57;
            // 
            // tbl_brLogTableAdapter
            // 
            this.tbl_brLogTableAdapter.ClearBeforeFill = true;
            // 
            // PRINT_bookLog_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(794, 471);
            this.Controls.Add(this.rpView);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PRINT_bookLog_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PRINT_bookLog_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_brLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button backBtn;
        private Microsoft.Reporting.WinForms.ReportViewer rpView;
        private System.Windows.Forms.BindingSource tbl_brLogBindingSource;
        private LibraryDataDataSet LibraryDataDataSet;
        private LibraryDataDataSetTableAdapters.tbl_brLogTableAdapter tbl_brLogTableAdapter;
    }
}