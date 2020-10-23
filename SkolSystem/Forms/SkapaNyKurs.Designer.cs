namespace SkolSystem.Forms
{
    partial class SkapaNyKurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxÅrsKurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKursTyp = new System.Windows.Forms.ComboBox();
            this.BtnSkapa = new System.Windows.Forms.Button();
            this.lbxAddElever = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs Typ";
            // 
            // tbxÅrsKurs
            // 
            this.tbxÅrsKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxÅrsKurs.Location = new System.Drawing.Point(151, 73);
            this.tbxÅrsKurs.Name = "tbxÅrsKurs";
            this.tbxÅrsKurs.Size = new System.Drawing.Size(133, 30);
            this.tbxÅrsKurs.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Årskurs";
            // 
            // cmbKursTyp
            // 
            this.cmbKursTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKursTyp.FormattingEnabled = true;
            this.cmbKursTyp.Location = new System.Drawing.Point(151, 28);
            this.cmbKursTyp.Name = "cmbKursTyp";
            this.cmbKursTyp.Size = new System.Drawing.Size(121, 33);
            this.cmbKursTyp.TabIndex = 9;
            // 
            // BtnSkapa
            // 
            this.BtnSkapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSkapa.Location = new System.Drawing.Point(494, 235);
            this.BtnSkapa.Name = "BtnSkapa";
            this.BtnSkapa.Size = new System.Drawing.Size(225, 75);
            this.BtnSkapa.TabIndex = 10;
            this.BtnSkapa.Text = "Skapa";
            this.BtnSkapa.UseVisualStyleBackColor = true;
            this.BtnSkapa.Click += new System.EventHandler(this.BtnSkapa_Click);
            // 
            // lbxAddElever
            // 
            this.lbxAddElever.FormattingEnabled = true;
            this.lbxAddElever.Location = new System.Drawing.Point(49, 148);
            this.lbxAddElever.Name = "lbxAddElever";
            this.lbxAddElever.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAddElever.Size = new System.Drawing.Size(363, 303);
            this.lbxAddElever.TabIndex = 11;
            // 
            // SkapaNyKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 493);
            this.Controls.Add(this.lbxAddElever);
            this.Controls.Add(this.BtnSkapa);
            this.Controls.Add(this.cmbKursTyp);
            this.Controls.Add(this.tbxÅrsKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SkapaNyKurs";
            this.Text = "SkapaNyKurs";
            this.Load += new System.EventHandler(this.SkapaNyKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxÅrsKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKursTyp;
        private System.Windows.Forms.Button BtnSkapa;
        private System.Windows.Forms.ListBox lbxAddElever;
    }
}