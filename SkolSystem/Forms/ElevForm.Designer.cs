namespace SkolSystem
{
    partial class ElevForm
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
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlasser = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxBetyg = new System.Windows.Forms.GroupBox();
            this.tbxBetyg = new System.Windows.Forms.TextBox();
            this.tbxKursStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxKursInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxPersonNummer = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxBetyg.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(47, 25);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(117, 25);
            this.lblWelcomeText.TabIndex = 0;
            this.lblWelcomeText.Text = "Hej, \"Namn\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mina Kurser:";
            // 
            // cmbKlasser
            // 
            this.cmbKlasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKlasser.FormattingEnabled = true;
            this.cmbKlasser.Location = new System.Drawing.Point(161, 6);
            this.cmbKlasser.Name = "cmbKlasser";
            this.cmbKlasser.Size = new System.Drawing.Size(215, 33);
            this.cmbKlasser.TabIndex = 2;
            this.cmbKlasser.SelectedIndexChanged += new System.EventHandler(this.cmbKlasser_SelectedIndexChanged);
            this.cmbKlasser.SelectionChangeCommitted += new System.EventHandler(this.cmbKlasser_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 480);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxBetyg);
            this.tabPage1.Controls.Add(this.tbxKursInfo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbKlasser);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mina Kurser";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxBetyg
            // 
            this.groupBoxBetyg.Controls.Add(this.tbxBetyg);
            this.groupBoxBetyg.Controls.Add(this.tbxKursStatus);
            this.groupBoxBetyg.Controls.Add(this.label2);
            this.groupBoxBetyg.Controls.Add(this.label6);
            this.groupBoxBetyg.Location = new System.Drawing.Point(578, 29);
            this.groupBoxBetyg.Name = "groupBoxBetyg";
            this.groupBoxBetyg.Size = new System.Drawing.Size(386, 405);
            this.groupBoxBetyg.TabIndex = 23;
            this.groupBoxBetyg.TabStop = false;
            this.groupBoxBetyg.Text = "Betyg i denna Kurs:";
            // 
            // tbxBetyg
            // 
            this.tbxBetyg.Location = new System.Drawing.Point(38, 173);
            this.tbxBetyg.Name = "tbxBetyg";
            this.tbxBetyg.ReadOnly = true;
            this.tbxBetyg.Size = new System.Drawing.Size(130, 20);
            this.tbxBetyg.TabIndex = 19;
            // 
            // tbxKursStatus
            // 
            this.tbxKursStatus.Location = new System.Drawing.Point(38, 66);
            this.tbxKursStatus.Name = "tbxKursStatus";
            this.tbxKursStatus.ReadOnly = true;
            this.tbxKursStatus.Size = new System.Drawing.Size(130, 20);
            this.tbxKursStatus.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kurs status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Betyg";
            // 
            // tbxKursInfo
            // 
            this.tbxKursInfo.Location = new System.Drawing.Point(39, 155);
            this.tbxKursInfo.Multiline = true;
            this.tbxKursInfo.Name = "tbxKursInfo";
            this.tbxKursInfo.ReadOnly = true;
            this.tbxKursInfo.Size = new System.Drawing.Size(220, 132);
            this.tbxKursInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kurs Info";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxPersonNummer);
            this.tabPage2.Controls.Add(this.tbxNamn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mitt Konto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxPersonNummer
            // 
            this.tbxPersonNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonNummer.Location = new System.Drawing.Point(213, 109);
            this.tbxPersonNummer.Name = "tbxPersonNummer";
            this.tbxPersonNummer.ReadOnly = true;
            this.tbxPersonNummer.Size = new System.Drawing.Size(96, 30);
            this.tbxPersonNummer.TabIndex = 7;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamn.Location = new System.Drawing.Point(213, 55);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.ReadOnly = true;
            this.tbxNamn.Size = new System.Drawing.Size(96, 30);
            this.tbxNamn.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Person Nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Namn";
            // 
            // ElevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 594);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcomeText);
            this.Name = "ElevForm";
            this.Text = "LärareForm";
            this.Load += new System.EventHandler(this.ElevForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxBetyg.ResumeLayout(false);
            this.groupBoxBetyg.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlasser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxKursInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPersonNummer;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxBetyg;
        private System.Windows.Forms.TextBox tbxBetyg;
        private System.Windows.Forms.TextBox tbxKursStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}