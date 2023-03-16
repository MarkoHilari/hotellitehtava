namespace Hotellitehtava
{
    partial class loginFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kirjauduBT = new System.Windows.Forms.Button();
            this.salaSanaTB = new System.Windows.Forms.TextBox();
            this.ktunnusTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1487, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tervetuloa hotellivarausjärjestelmään";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 662);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kirjaudu sisään sovellukseen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kirjauduBT);
            this.groupBox1.Controls.Add(this.salaSanaTB);
            this.groupBox1.Controls.Add(this.ktunnusTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(387, 719);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(752, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // kirjauduBT
            // 
            this.kirjauduBT.BackColor = System.Drawing.Color.Gray;
            this.kirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduBT.Location = new System.Drawing.Point(353, 166);
            this.kirjauduBT.Margin = new System.Windows.Forms.Padding(4);
            this.kirjauduBT.Name = "kirjauduBT";
            this.kirjauduBT.Size = new System.Drawing.Size(216, 45);
            this.kirjauduBT.TabIndex = 4;
            this.kirjauduBT.Text = "Kirjaudu sisään";
            this.kirjauduBT.UseVisualStyleBackColor = false;
            this.kirjauduBT.Click += new System.EventHandler(this.kirjauduBT_Click);
            // 
            // salaSanaTB
            // 
            this.salaSanaTB.Location = new System.Drawing.Point(353, 106);
            this.salaSanaTB.Margin = new System.Windows.Forms.Padding(4);
            this.salaSanaTB.Name = "salaSanaTB";
            this.salaSanaTB.Size = new System.Drawing.Size(301, 31);
            this.salaSanaTB.TabIndex = 3;
            this.salaSanaTB.Text = "password";
            this.salaSanaTB.UseSystemPasswordChar = true;
            // 
            // ktunnusTB
            // 
            this.ktunnusTB.Location = new System.Drawing.Point(353, 48);
            this.ktunnusTB.Margin = new System.Windows.Forms.Padding(4);
            this.ktunnusTB.Name = "ktunnusTB";
            this.ktunnusTB.Size = new System.Drawing.Size(301, 31);
            this.ktunnusTB.TabIndex = 2;
            this.ktunnusTB.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salasana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Käyttäjätunnus:";
            // 
            // loginFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1543, 1007);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginFM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjautumisikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kirjauduBT;
        private System.Windows.Forms.TextBox salaSanaTB;
        private System.Windows.Forms.TextBox ktunnusTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

