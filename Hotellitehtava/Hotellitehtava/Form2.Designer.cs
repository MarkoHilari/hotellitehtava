namespace Hotellitehtava
{
    partial class paaikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paaikkuna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.henkiloMS = new System.Windows.Forms.ToolStripMenuItem();
            this.varausMS = new System.Windows.Forms.ToolStripMenuItem();
            this.HuoneMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.henkiloMS,
            this.varausMS,
            this.HuoneMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1516, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // henkiloMS
            // 
            this.henkiloMS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.henkiloMS.Name = "henkiloMS";
            this.henkiloMS.Size = new System.Drawing.Size(341, 42);
            this.henkiloMS.Text = "Hallitse henkilökunta";
            this.henkiloMS.Click += new System.EventHandler(this.henkiloMS_Click);
            // 
            // varausMS
            // 
            this.varausMS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausMS.Name = "varausMS";
            this.varausMS.Size = new System.Drawing.Size(290, 42);
            this.varausMS.Text = "Hallitse varauksia";
            this.varausMS.Click += new System.EventHandler(this.varausMS_Click);
            // 
            // HuoneMS
            // 
            this.HuoneMS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneMS.Name = "HuoneMS";
            this.HuoneMS.Size = new System.Drawing.Size(279, 42);
            this.HuoneMS.Text = "Hallitse huoneita";
            this.HuoneMS.Click += new System.EventHandler(this.HuoneMS_Click);
            // 
            // paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1516, 995);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "paaikkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pääikkuna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.paaikkuna_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem henkiloMS;
        private System.Windows.Forms.ToolStripMenuItem varausMS;
        private System.Windows.Forms.ToolStripMenuItem HuoneMS;
    }
}