namespace SkolSystem.Forms
{
    partial class Register
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
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPersonNummber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegeriser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamn.Location = new System.Drawing.Point(260, 122);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(113, 30);
            this.tbxNamn.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(260, 173);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(113, 30);
            this.tbxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord:";
            // 
            // tbxPersonNummber
            // 
            this.tbxPersonNummber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPersonNummber.Location = new System.Drawing.Point(260, 230);
            this.tbxPersonNummber.Name = "tbxPersonNummber";
            this.tbxPersonNummber.Size = new System.Drawing.Size(113, 30);
            this.tbxPersonNummber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Person Nummer:";
            // 
            // BtnRegeriser
            // 
            this.BtnRegeriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegeriser.Location = new System.Drawing.Point(217, 301);
            this.BtnRegeriser.Name = "BtnRegeriser";
            this.BtnRegeriser.Size = new System.Drawing.Size(156, 66);
            this.BtnRegeriser.TabIndex = 6;
            this.BtnRegeriser.Text = "Regestera";
            this.BtnRegeriser.UseVisualStyleBackColor = true;
            this.BtnRegeriser.Click += new System.EventHandler(this.BtnRegeriser_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 540);
            this.Controls.Add(this.BtnRegeriser);
            this.Controls.Add(this.tbxPersonNummber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPersonNummber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegeriser;
    }
}