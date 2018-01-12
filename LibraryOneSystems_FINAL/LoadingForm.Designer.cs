namespace LibraryOneSystems_FINAL
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.loadingLbl = new System.Windows.Forms.Label();
            this.loadingTM = new System.Windows.Forms.Timer(this.components);
            this.animationTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loadingLbl.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLbl.Location = new System.Drawing.Point(652, 601);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(323, 90);
            this.loadingLbl.TabIndex = 14;
            this.loadingLbl.Text = "Loading .";
            this.loadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingTM
            // 
            this.loadingTM.Enabled = true;
            this.loadingTM.Interval = 150;
            this.loadingTM.Tick += new System.EventHandler(this.loadingTM_Tick);
            // 
            // animationTM
            // 
            this.animationTM.Enabled = true;
            this.animationTM.Interval = 50;
            this.animationTM.Tick += new System.EventHandler(this.animationTM_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.loadingLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.Timer loadingTM;
        private System.Windows.Forms.Timer animationTM;
    }
}