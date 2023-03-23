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
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 228);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(520, 67);
            this.label7.TabIndex = 0;
            this.label7.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 615);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ulos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 544);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sisään:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huoneen nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Huonetyyppi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Asiakas nro:";
            // 
            // huoneenNumeroCB
            // 
            this.huoneenNumeroCB.FormattingEnabled = true;
            this.huoneenNumeroCB.Location = new System.Drawing.Point(304, 474);
            this.huoneenNumeroCB.Margin = new System.Windows.Forms.Padding(4);
            this.huoneenNumeroCB.Name = "huoneenNumeroCB";
            this.huoneenNumeroCB.Size = new System.Drawing.Size(188, 33);
            this.huoneenNumeroCB.TabIndex = 10;
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(304, 400);
            this.huonetyyppiCB.Margin = new System.Windows.Forms.Padding(4);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(188, 33);
            this.huonetyyppiCB.TabIndex = 11;
            this.huonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huonetyyppiCB_SelectedIndexChanged);
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.CustomFormat = "dd/MM/yyyy";
            this.sisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sisaanDTP.Location = new System.Drawing.Point(304, 546);
            this.sisaanDTP.Margin = new System.Windows.Forms.Padding(4);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(188, 31);
            this.sisaanDTP.TabIndex = 12;
            // 
            // ulosDTP
            // 
            this.ulosDTP.CustomFormat = "dd/MM/yyyy";
            this.ulosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ulosDTP.Location = new System.Drawing.Point(304, 619);
            this.ulosDTP.Margin = new System.Windows.Forms.Padding(4);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(188, 31);
            this.ulosDTP.TabIndex = 13;
            // 
            // varausDG
            // 
            this.varausDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausDG.Location = new System.Drawing.Point(537, 225);
            this.varausDG.Margin = new System.Windows.Forms.Padding(4);
            this.varausDG.Name = "varausDG";
            this.varausDG.RowHeadersWidth = 62;
            this.varausDG.RowTemplate.Height = 28;
            this.varausDG.Size = new System.Drawing.Size(1028, 701);
            this.varausDG.TabIndex = 14;
            this.varausDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellClick);
            // 
            // uusiVarausBT
            // 
            this.uusiVarausBT.Location = new System.Drawing.Point(16, 711);
            this.uusiVarausBT.Margin = new System.Windows.Forms.Padding(4);
            this.uusiVarausBT.Name = "uusiVarausBT";
            this.uusiVarausBT.Size = new System.Drawing.Size(165, 48);
            this.uusiVarausBT.TabIndex = 15;
            this.uusiVarausBT.Text = "Lisää varaus";
            this.uusiVarausBT.UseVisualStyleBackColor = true;
            this.uusiVarausBT.Click += new System.EventHandler(this.uusiVarausBT_Click);
            // 
            // tyhjennaVarausKenttaBT
            // 
            this.tyhjennaVarausKenttaBT.Location = new System.Drawing.Point(287, 804);
            this.tyhjennaVarausKenttaBT.Margin = new System.Windows.Forms.Padding(4);
            this.tyhjennaVarausKenttaBT.Name = "tyhjennaVarausKenttaBT";
            this.tyhjennaVarausKenttaBT.Size = new System.Drawing.Size(207, 48);
            this.tyhjennaVarausKenttaBT.TabIndex = 16;
            this.tyhjennaVarausKenttaBT.Text = "Tyhjennä kentät";
            this.tyhjennaVarausKenttaBT.UseVisualStyleBackColor = true;
            this.tyhjennaVarausKenttaBT.Click += new System.EventHandler(this.tyhjennaVarausKenttaBT_Click);
            // 
            // poistaVarausBT
            // 
            this.poistaVarausBT.Location = new System.Drawing.Point(372, 711);
            this.poistaVarausBT.Margin = new System.Windows.Forms.Padding(4);
            this.poistaVarausBT.Name = "poistaVarausBT";
            this.poistaVarausBT.Size = new System.Drawing.Size(121, 48);
            this.poistaVarausBT.TabIndex = 17;
            this.poistaVarausBT.Text = "Poista";
            this.poistaVarausBT.UseVisualStyleBackColor = true;
            // 
            // muokkaaVarausBT
            // 
            this.muokkaaVarausBT.Location = new System.Drawing.Point(189, 711);
            this.muokkaaVarausBT.Margin = new System.Windows.Forms.Padding(4);
            this.muokkaaVarausBT.Name = "muokkaaVarausBT";
            this.muokkaaVarausBT.Size = new System.Drawing.Size(175, 48);
            this.muokkaaVarausBT.TabIndex = 18;
            this.muokkaaVarausBT.Text = "Muokkaa";
            this.muokkaaVarausBT.UseVisualStyleBackColor = true;
            this.muokkaaVarausBT.Click += new System.EventHandler(this.muokkaaVarausBT_Click);
            // 
            // asiakasNroTB
            // 
            this.asiakasNroTB.Location = new System.Drawing.Point(304, 330);
            this.asiakasNroTB.Name = "asiakasNroTB";
            this.asiakasNroTB.Size = new System.Drawing.Size(190, 31);
            this.asiakasNroTB.TabIndex = 19;
            // 
            // varausTB
            // 
            this.varausTB.Location = new System.Drawing.Point(304, 272);
            this.varausTB.Name = "varausTB";
            this.varausTB.Size = new System.Drawing.Size(190, 31);
            this.varausTB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Varaus nro:";
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1608, 969);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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