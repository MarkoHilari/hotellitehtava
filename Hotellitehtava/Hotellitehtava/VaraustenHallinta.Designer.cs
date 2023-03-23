namespace Hotellitehtava
{
    partial class VaraustenHallinta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.huoneenNumeroCB = new System.Windows.Forms.ComboBox();
            this.huonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.varausDG = new System.Windows.Forms.DataGridView();
            this.uusiVarausBT = new System.Windows.Forms.Button();
            this.tyhjennaVarausKenttaBT = new System.Windows.Forms.Button();
            this.poistaVarausBT = new System.Windows.Forms.Button();
            this.muokkaaVarausBT = new System.Windows.Forms.Button();
            this.asiakasNroTB = new System.Windows.Forms.TextBox();
            this.varausTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 182);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 52);
            this.label7.TabIndex = 0;
            this.label7.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ulos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sisään:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huoneen nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Huonetyyppi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Asiakas nro:";
            // 
            // huoneenNumeroCB
            // 
            this.huoneenNumeroCB.FormattingEnabled = true;
            this.huoneenNumeroCB.Location = new System.Drawing.Point(228, 379);
            this.huoneenNumeroCB.Name = "huoneenNumeroCB";
            this.huoneenNumeroCB.Size = new System.Drawing.Size(142, 28);
            this.huoneenNumeroCB.TabIndex = 10;
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(228, 320);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(142, 28);
            this.huonetyyppiCB.TabIndex = 11;
            this.huonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huonetyyppiCB_SelectedIndexChanged);
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.CustomFormat = "dd/MM/yyyy";
            this.sisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sisaanDTP.Location = new System.Drawing.Point(228, 437);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(142, 26);
            this.sisaanDTP.TabIndex = 12;
            // 
            // ulosDTP
            // 
            this.ulosDTP.CustomFormat = "dd/MM/yyyy";
            this.ulosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ulosDTP.Location = new System.Drawing.Point(228, 495);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(142, 26);
            this.ulosDTP.TabIndex = 13;
            // 
            // varausDG
            // 
            this.varausDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausDG.Location = new System.Drawing.Point(403, 180);
            this.varausDG.Name = "varausDG";
            this.varausDG.RowHeadersWidth = 62;
            this.varausDG.RowTemplate.Height = 28;
            this.varausDG.Size = new System.Drawing.Size(771, 561);
            this.varausDG.TabIndex = 14;
            this.varausDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellClick);
            // 
            // uusiVarausBT
            // 
            this.uusiVarausBT.Location = new System.Drawing.Point(12, 569);
            this.uusiVarausBT.Name = "uusiVarausBT";
            this.uusiVarausBT.Size = new System.Drawing.Size(124, 38);
            this.uusiVarausBT.TabIndex = 15;
            this.uusiVarausBT.Text = "Lisää varaus";
            this.uusiVarausBT.UseVisualStyleBackColor = true;
            this.uusiVarausBT.Click += new System.EventHandler(this.uusiVarausBT_Click);
            // 
            // tyhjennaVarausKenttaBT
            // 
            this.tyhjennaVarausKenttaBT.Location = new System.Drawing.Point(215, 643);
            this.tyhjennaVarausKenttaBT.Name = "tyhjennaVarausKenttaBT";
            this.tyhjennaVarausKenttaBT.Size = new System.Drawing.Size(155, 38);
            this.tyhjennaVarausKenttaBT.TabIndex = 16;
            this.tyhjennaVarausKenttaBT.Text = "Tyhjennä kentät";
            this.tyhjennaVarausKenttaBT.UseVisualStyleBackColor = true;
            this.tyhjennaVarausKenttaBT.Click += new System.EventHandler(this.tyhjennaVarausKenttaBT_Click);
            // 
            // poistaVarausBT
            // 
            this.poistaVarausBT.Location = new System.Drawing.Point(279, 569);
            this.poistaVarausBT.Name = "poistaVarausBT";
            this.poistaVarausBT.Size = new System.Drawing.Size(91, 38);
            this.poistaVarausBT.TabIndex = 17;
            this.poistaVarausBT.Text = "Poista";
            this.poistaVarausBT.UseVisualStyleBackColor = true;
            this.poistaVarausBT.Click += new System.EventHandler(this.poistaVarausBT_Click);
            // 
            // muokkaaVarausBT
            // 
            this.muokkaaVarausBT.Location = new System.Drawing.Point(142, 569);
            this.muokkaaVarausBT.Name = "muokkaaVarausBT";
            this.muokkaaVarausBT.Size = new System.Drawing.Size(131, 38);
            this.muokkaaVarausBT.TabIndex = 18;
            this.muokkaaVarausBT.Text = "Muokkaa";
            this.muokkaaVarausBT.UseVisualStyleBackColor = true;
            this.muokkaaVarausBT.Click += new System.EventHandler(this.muokkaaVarausBT_Click);
            // 
            // asiakasNroTB
            // 
            this.asiakasNroTB.Location = new System.Drawing.Point(228, 264);
            this.asiakasNroTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asiakasNroTB.Name = "asiakasNroTB";
            this.asiakasNroTB.Size = new System.Drawing.Size(144, 26);
            this.asiakasNroTB.TabIndex = 19;
            // 
            // varausTB
            // 
            this.varausTB.Location = new System.Drawing.Point(228, 218);
            this.varausTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.varausTB.Name = "varausTB";
            this.varausTB.Size = new System.Drawing.Size(144, 26);
            this.varausTB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Varaus nro:";
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1206, 775);
            this.Controls.Add(this.varausTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asiakasNroTB);
            this.Controls.Add(this.muokkaaVarausBT);
            this.Controls.Add(this.poistaVarausBT);
            this.Controls.Add(this.tyhjennaVarausKenttaBT);
            this.Controls.Add(this.uusiVarausBT);
            this.Controls.Add(this.varausDG);
            this.Controls.Add(this.ulosDTP);
            this.Controls.Add(this.sisaanDTP);
            this.Controls.Add(this.huonetyyppiCB);
            this.Controls.Add(this.huoneenNumeroCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "VaraustenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox huoneenNumeroCB;
        private System.Windows.Forms.ComboBox huonetyyppiCB;
        private System.Windows.Forms.DateTimePicker sisaanDTP;
        private System.Windows.Forms.DateTimePicker ulosDTP;
        private System.Windows.Forms.DataGridView varausDG;
        private System.Windows.Forms.Button uusiVarausBT;
        private System.Windows.Forms.Button tyhjennaVarausKenttaBT;
        private System.Windows.Forms.Button poistaVarausBT;
        private System.Windows.Forms.Button muokkaaVarausBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox asiakasNroTB;
        private System.Windows.Forms.TextBox varausTB;
        private System.Windows.Forms.Label label1;
    }
}