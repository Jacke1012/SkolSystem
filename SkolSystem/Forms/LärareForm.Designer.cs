namespace SkolSystem
{
    partial class LärareForm
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
            this.BtnNyKurs = new System.Windows.Forms.Button();
            this.tbxKursInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxElever = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxPersonNummer = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.BtnNyKurs);
            this.tabPage1.Controls.Add(this.tbxKursInfo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbxElever);
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
            // BtnNyKurs
            // 
            this.BtnNyKurs.Location = new System.Drawing.Point(462, 15);
            this.BtnNyKurs.Name = "BtnNyKurs";
            this.BtnNyKurs.Size = new System.Drawing.Size(119, 39);
            this.BtnNyKurs.TabIndex = 7;
            this.BtnNyKurs.Text = "Skapa ny kurs";
            this.BtnNyKurs.UseVisualStyleBackColor = true;
            this.BtnNyKurs.Click += new System.EventHandler(this.BtnNyKurs_Click);
            // 
            // tbxKursInfo
            // 
            this.tbxKursInfo.Location = new System.Drawing.Point(470, 155);
            this.tbxKursInfo.Multiline = true;
            this.tbxKursInfo.Name = "tbxKursInfo";
            this.tbxKursInfo.Size = new System.Drawing.Size(220, 132);
            this.tbxKursInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kurs Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elever";
            // 
            // lbxElever
            // 
            this.lbxElever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxElever.FormattingEnabled = true;
            this.lbxElever.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbxElever.ItemHeight = 16;
            this.lbxElever.Location = new System.Drawing.Point(34, 102);
            this.lbxElever.Name = "lbxElever";
            this.lbxElever.Size = new System.Drawing.Size(357, 292);
            this.lbxElever.TabIndex = 3;
            this.lbxElever.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxElever_MouseDoubleClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Namn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Person Nummer";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamn.Location = new System.Drawing.Point(221, 71);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(96, 30);
            this.tbxNamn.TabIndex = 2;
            // 
            // tbxPersonNummer
            // 
            this.tbxPersonNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonNummer.Location = new System.Drawing.Point(221, 125);
            this.tbxPersonNummer.Name = "tbxPersonNummer";
            this.tbxPersonNummer.Size = new System.Drawing.Size(96, 30);
            this.tbxPersonNummer.TabIndex = 3;
            // 
            // LärareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 594);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcomeText);
            this.Name = "LärareForm";
            this.Text = "LärareForm";
            this.Load += new System.EventHandler(this.LärareForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxElever;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxKursInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNyKurs;
        private System.Windows.Forms.TextBox tbxPersonNummer;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}