namespace SkolSystem.Forms
{
    partial class ElevProfile
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
            this.tbxPersonNummer = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKurser = new System.Windows.Forms.Label();
            this.lbxKlasser = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.BtnSpara = new System.Windows.Forms.Button();
            this.cmbBetyg = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBetyg = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxBetyg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPersonNummer
            // 
            this.tbxPersonNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonNummer.Location = new System.Drawing.Point(191, 78);
            this.tbxPersonNummer.Name = "tbxPersonNummer";
            this.tbxPersonNummer.ReadOnly = true;
            this.tbxPersonNummer.Size = new System.Drawing.Size(96, 30);
            this.tbxPersonNummer.TabIndex = 11;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamn.Location = new System.Drawing.Point(191, 24);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.ReadOnly = true;
            this.tbxNamn.Size = new System.Drawing.Size(96, 30);
            this.tbxNamn.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Person Nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namn";
            // 
            // lblKurser
            // 
            this.lblKurser.AutoSize = true;
            this.lblKurser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKurser.Location = new System.Drawing.Point(23, 183);
            this.lblKurser.Name = "lblKurser";
            this.lblKurser.Size = new System.Drawing.Size(133, 25);
            this.lblKurser.TabIndex = 12;
            this.lblKurser.Text = "Namn Kurser:";
            // 
            // lbxKlasser
            // 
            this.lbxKlasser.FormattingEnabled = true;
            this.lbxKlasser.Location = new System.Drawing.Point(162, 183);
            this.lbxKlasser.Name = "lbxKlasser";
            this.lbxKlasser.Size = new System.Drawing.Size(231, 160);
            this.lbxKlasser.TabIndex = 14;
            this.lbxKlasser.SelectedIndexChanged += new System.EventHandler(this.lbxKlasser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Betyg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kurs status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pågående",
            "Avslutad"});
            this.cmbStatus.Location = new System.Drawing.Point(38, 63);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(164, 21);
            this.cmbStatus.TabIndex = 18;
            // 
            // BtnSpara
            // 
            this.BtnSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpara.Location = new System.Drawing.Point(231, 179);
            this.BtnSpara.Name = "BtnSpara";
            this.BtnSpara.Size = new System.Drawing.Size(100, 49);
            this.BtnSpara.TabIndex = 19;
            this.BtnSpara.Text = "Spara";
            this.BtnSpara.UseVisualStyleBackColor = true;
            this.BtnSpara.Click += new System.EventHandler(this.BtnSpara_Click);
            // 
            // cmbBetyg
            // 
            this.cmbBetyg.FormattingEnabled = true;
            this.cmbBetyg.Items.AddRange(new object[] {
            "F",
            "E",
            "D",
            "C",
            "B",
            "A"});
            this.cmbBetyg.Location = new System.Drawing.Point(38, 179);
            this.cmbBetyg.Name = "cmbBetyg";
            this.cmbBetyg.Size = new System.Drawing.Size(164, 21);
            this.cmbBetyg.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxKlasser);
            this.groupBox1.Controls.Add(this.lblKurser);
            this.groupBox1.Controls.Add(this.tbxPersonNummer);
            this.groupBox1.Controls.Add(this.tbxNamn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 410);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elev Info";
            // 
            // groupBoxBetyg
            // 
            this.groupBoxBetyg.Controls.Add(this.cmbBetyg);
            this.groupBoxBetyg.Controls.Add(this.BtnSpara);
            this.groupBoxBetyg.Controls.Add(this.cmbStatus);
            this.groupBoxBetyg.Controls.Add(this.label3);
            this.groupBoxBetyg.Controls.Add(this.label2);
            this.groupBoxBetyg.Location = new System.Drawing.Point(469, 22);
            this.groupBoxBetyg.Name = "groupBoxBetyg";
            this.groupBoxBetyg.Size = new System.Drawing.Size(386, 405);
            this.groupBoxBetyg.TabIndex = 22;
            this.groupBoxBetyg.TabStop = false;
            this.groupBoxBetyg.Text = "Betyg i denna Kurs:";
            // 
            // ElevProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 465);
            this.Controls.Add(this.groupBoxBetyg);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElevProfile";
            this.Text = "ElevProfile";
            this.Load += new System.EventHandler(this.ElevProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBetyg.ResumeLayout(false);
            this.groupBoxBetyg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPersonNummer;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKurser;
        private System.Windows.Forms.ListBox lbxKlasser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button BtnSpara;
        private System.Windows.Forms.ComboBox cmbBetyg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxBetyg;
    }
}