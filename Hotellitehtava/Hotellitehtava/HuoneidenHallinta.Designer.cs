﻿namespace Hotellitehtava
{
    partial class HuoneidenHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuoneidenHallinta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.huoneNroTB = new System.Windows.Forms.TextBox();
            this.hallintaPuhTB = new System.Windows.Forms.TextBox();
            this.lisaaHuoBT = new System.Windows.Forms.Button();
            this.muokkaaHuoTB = new System.Windows.Forms.Button();
            this.poistaHuoTB = new System.Windows.Forms.Button();
            this.tyhjennaKenTB = new System.Windows.Forms.Button();
            this.hallintaDG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.huoTyypCB = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.hallintaDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneen nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huonetyyppi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puhelin nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vapaa:";
            // 
            // huoneNroTB
            // 
            this.huoneNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroTB.Location = new System.Drawing.Point(351, 205);
            this.huoneNroTB.Name = "huoneNroTB";
            this.huoneNroTB.Size = new System.Drawing.Size(262, 38);
            this.huoneNroTB.TabIndex = 4;
            // 
            // hallintaPuhTB
            // 
            this.hallintaPuhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallintaPuhTB.Location = new System.Drawing.Point(351, 329);
            this.hallintaPuhTB.Name = "hallintaPuhTB";
            this.hallintaPuhTB.Size = new System.Drawing.Size(262, 38);
            this.hallintaPuhTB.TabIndex = 6;
            // 
            // lisaaHuoBT
            // 
            this.lisaaHuoBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaHuoBT.Location = new System.Drawing.Point(54, 494);
            this.lisaaHuoBT.Name = "lisaaHuoBT";
            this.lisaaHuoBT.Size = new System.Drawing.Size(209, 52);
            this.lisaaHuoBT.TabIndex = 8;
            this.lisaaHuoBT.Text = "Lisää Huone";
            this.lisaaHuoBT.UseVisualStyleBackColor = true;
            this.lisaaHuoBT.Click += new System.EventHandler(this.lisaaHuoBT_Click);
            // 
            // muokkaaHuoTB
            // 
            this.muokkaaHuoTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaHuoTB.Location = new System.Drawing.Point(322, 494);
            this.muokkaaHuoTB.Name = "muokkaaHuoTB";
            this.muokkaaHuoTB.Size = new System.Drawing.Size(266, 52);
            this.muokkaaHuoTB.TabIndex = 9;
            this.muokkaaHuoTB.Text = "Muokkaa";
            this.muokkaaHuoTB.UseVisualStyleBackColor = true;
            this.muokkaaHuoTB.Click += new System.EventHandler(this.muokkaaHuoTB_Click);
            // 
            // poistaHuoTB
            // 
            this.poistaHuoTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaHuoTB.Location = new System.Drawing.Point(64, 578);
            this.poistaHuoTB.Name = "poistaHuoTB";
            this.poistaHuoTB.Size = new System.Drawing.Size(199, 52);
            this.poistaHuoTB.TabIndex = 10;
            this.poistaHuoTB.Text = "Poista";
            this.poistaHuoTB.UseVisualStyleBackColor = true;
            this.poistaHuoTB.Click += new System.EventHandler(this.poistaHuoTB_Click);
            // 
            // tyhjennaKenTB
            // 
            this.tyhjennaKenTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaKenTB.Location = new System.Drawing.Point(322, 578);
            this.tyhjennaKenTB.Name = "tyhjennaKenTB";
            this.tyhjennaKenTB.Size = new System.Drawing.Size(266, 52);
            this.tyhjennaKenTB.TabIndex = 11;
            this.tyhjennaKenTB.Text = "Tyhjennä kentät";
            this.tyhjennaKenTB.UseVisualStyleBackColor = true;
            this.tyhjennaKenTB.Click += new System.EventHandler(this.tyhjennaKenTB_Click);
            // 
            // hallintaDG
            // 
            this.hallintaDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hallintaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallintaDG.Location = new System.Drawing.Point(664, 202);
            this.hallintaDG.Name = "hallintaDG";
            this.hallintaDG.RowHeadersWidth = 82;
            this.hallintaDG.RowTemplate.Height = 33;
            this.hallintaDG.Size = new System.Drawing.Size(704, 452);
            this.hallintaDG.TabIndex = 12;
            this.hallintaDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hallintaDG_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 172);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 67);
            this.label5.TabIndex = 0;
            this.label5.Text = "Huoneiden hallinta";
            // 
            // huoTyypCB
            // 
            this.huoTyypCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.huoTyypCB.FormattingEnabled = true;
            this.huoTyypCB.Location = new System.Drawing.Point(351, 263);
            this.huoTyypCB.Name = "huoTyypCB";
            this.huoTyypCB.Size = new System.Drawing.Size(262, 33);
            this.huoTyypCB.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonNo);
            this.panel2.Controls.Add(this.radioButtonYes);
            this.panel2.Location = new System.Drawing.Point(337, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 68);
            this.panel2.TabIndex = 15;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYes.Location = new System.Drawing.Point(19, 17);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(129, 35);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "KYLLÄ";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNo.Location = new System.Drawing.Point(175, 17);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(71, 35);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.Text = "EI";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.huoTyypCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hallintaDG);
            this.Controls.Add(this.tyhjennaKenTB);
            this.Controls.Add(this.poistaHuoTB);
            this.Controls.Add(this.muokkaaHuoTB);
            this.Controls.Add(this.lisaaHuoBT);
            this.Controls.Add(this.hallintaPuhTB);
            this.Controls.Add(this.huoneNroTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HuoneidenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hallintaDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox huoneNroTB;
        private System.Windows.Forms.TextBox hallintaPuhTB;
        private System.Windows.Forms.Button lisaaHuoBT;
        private System.Windows.Forms.Button muokkaaHuoTB;
        private System.Windows.Forms.Button poistaHuoTB;
        private System.Windows.Forms.Button tyhjennaKenTB;
        private System.Windows.Forms.DataGridView hallintaDG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox huoTyypCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}