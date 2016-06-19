namespace BugFixer
{
	partial class Anmelden
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
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrieren = new System.Windows.Forms.Button();
            this.buttonAnmelden = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(90, 6);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(178, 22);
            this.textBoxNickname.TabIndex = 1;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(90, 34);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(178, 22);
            this.textBoxPasswort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passwort:";
            // 
            // buttonRegistrieren
            // 
            this.buttonRegistrieren.Location = new System.Drawing.Point(148, 62);
            this.buttonRegistrieren.Name = "buttonRegistrieren";
            this.buttonRegistrieren.Size = new System.Drawing.Size(120, 25);
            this.buttonRegistrieren.TabIndex = 4;
            this.buttonRegistrieren.Text = "Registrieren";
            this.buttonRegistrieren.UseVisualStyleBackColor = true;
            this.buttonRegistrieren.Click += new System.EventHandler(this.buttonRegistrieren_Click);
            // 
            // buttonAnmelden
            // 
            this.buttonAnmelden.Location = new System.Drawing.Point(12, 62);
            this.buttonAnmelden.Name = "buttonAnmelden";
            this.buttonAnmelden.Size = new System.Drawing.Size(120, 25);
            this.buttonAnmelden.TabIndex = 5;
            this.buttonAnmelden.Text = "Anmelden";
            this.buttonAnmelden.UseVisualStyleBackColor = true;
            this.buttonAnmelden.Click += new System.EventHandler(this.buttonAnmelden_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelStatus.Location = new System.Drawing.Point(12, 90);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 16);
            this.labelStatus.TabIndex = 6;
            // 
            // Anmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 130);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonAnmelden);
            this.Controls.Add(this.buttonRegistrieren);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anmelden";
            this.Text = "Anmelden";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNickname;
		private System.Windows.Forms.TextBox textBoxPasswort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonRegistrieren;
		private System.Windows.Forms.Button buttonAnmelden;
        private System.Windows.Forms.Label labelStatus;
	}
}