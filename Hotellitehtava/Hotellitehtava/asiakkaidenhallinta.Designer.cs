namespace Hotellitehtava
{
    partial class asiakkaidenhallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asiakkaidenhallinta));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.etuTB = new System.Windows.Forms.TextBox();
            this.sukuTB = new System.Windows.Forms.TextBox();
            this.lahiTB = new System.Windows.Forms.TextBox();
            this.postinroTB = new System.Windows.Forms.TextBox();
            this.kauttajaTB = new System.Windows.Forms.TextBox();
            this.salasTB = new System.Windows.Forms.TextBox();
            this.uusiAsBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(732, 607);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lähiosoite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postinumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-8, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Käyttäjätunnus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 468);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salasana:";
            // 
            // etuTB
            // 
            this.etuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etuTB.Location = new System.Drawing.Point(234, 234);
            this.etuTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.etuTB.Name = "etuTB";
            this.etuTB.Size = new System.Drawing.Size(198, 32);
            this.etuTB.TabIndex = 7;
            // 
            // sukuTB
            // 
            this.sukuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukuTB.Location = new System.Drawing.Point(234, 278);
            this.sukuTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sukuTB.Name = "sukuTB";
            this.sukuTB.Size = new System.Drawing.Size(198, 32);
            this.sukuTB.TabIndex = 8;
            // 
            // lahiTB
            // 
            this.lahiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lahiTB.Location = new System.Drawing.Point(234, 325);
            this.lahiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lahiTB.Name = "lahiTB";
            this.lahiTB.Size = new System.Drawing.Size(198, 32);
            this.lahiTB.TabIndex = 9;
            // 
            // postinroTB
            // 
            this.postinroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinroTB.Location = new System.Drawing.Point(234, 370);
            this.postinroTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postinroTB.Name = "postinroTB";
            this.postinroTB.Size = new System.Drawing.Size(198, 32);
            this.postinroTB.TabIndex = 10;
            // 
            // kauttajaTB
            // 
            this.kauttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kauttajaTB.Location = new System.Drawing.Point(234, 419);
            this.kauttajaTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kauttajaTB.Name = "kauttajaTB";
            this.kauttajaTB.ReadOnly = true;
            this.kauttajaTB.Size = new System.Drawing.Size(198, 32);
            this.kauttajaTB.TabIndex = 11;
            // 
            // salasTB
            // 
            this.salasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasTB.Location = new System.Drawing.Point(234, 467);
            this.salasTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salasTB.Name = "salasTB";
            this.salasTB.Size = new System.Drawing.Size(198, 32);
            this.salasTB.TabIndex = 12;
            // 
            // uusiAsBT
            // 
            this.uusiAsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uusiAsBT.Location = new System.Drawing.Point(38, 573);
            this.uusiAsBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uusiAsBT.Name = "uusiAsBT";
            this.uusiAsBT.Size = new System.Drawing.Size(160, 41);
            this.uusiAsBT.TabIndex = 13;
            this.uusiAsBT.Text = "Lisää asiakas";
            this.uusiAsBT.UseVisualStyleBackColor = true;
            this.uusiAsBT.Click += new System.EventHandler(this.uusiAsBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaBT.Location = new System.Drawing.Point(270, 573);
            this.muokkaaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(160, 41);
            this.muokkaaBT.TabIndex = 14;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(38, 669);
            this.PoistaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(171, 41);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(260, 669);
            this.tyhjennaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(170, 41);
            this.tyhjennaBT.TabIndex = 16;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // asiakkaidenhallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 834);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.uusiAsBT);
            this.Controls.Add(this.salasTB);
            this.Controls.Add(this.kauttajaTB);
            this.Controls.Add(this.postinroTB);
            this.Controls.Add(this.lahiTB);
            this.Controls.Add(this.sukuTB);
            this.Controls.Add(this.etuTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "asiakkaidenhallinta";
            this.Text = "asiakkaidenhallinta";
            this.Load += new System.EventHandler(this.asiakkaidenhallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox etuTB;
        private System.Windows.Forms.TextBox sukuTB;
        private System.Windows.Forms.TextBox lahiTB;
        private System.Windows.Forms.TextBox postinroTB;
        private System.Windows.Forms.TextBox kauttajaTB;
        private System.Windows.Forms.TextBox salasTB;
        private System.Windows.Forms.Button uusiAsBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button tyhjennaBT;
    }
}