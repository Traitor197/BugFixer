namespace BugFixer
{
	partial class Spiel
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spiel));
            this.listBoxProgrammierer = new System.Windows.Forms.ListBox();
            this.listBoxVirensucher = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProgrammierer
            // 
            this.listBoxProgrammierer.FormattingEnabled = true;
            this.listBoxProgrammierer.ItemHeight = 16;
            this.listBoxProgrammierer.Location = new System.Drawing.Point(12, 87);
            this.listBoxProgrammierer.Name = "listBoxProgrammierer";
            this.listBoxProgrammierer.Size = new System.Drawing.Size(302, 212);
            this.listBoxProgrammierer.TabIndex = 0;
            // 
            // listBoxVirensucher
            // 
            this.listBoxVirensucher.FormattingEnabled = true;
            this.listBoxVirensucher.ItemHeight = 16;
            this.listBoxVirensucher.Location = new System.Drawing.Point(320, 87);
            this.listBoxVirensucher.Name = "listBoxVirensucher";
            this.listBoxVirensucher.Size = new System.Drawing.Size(366, 212);
            this.listBoxVirensucher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angemeldet mit Account:";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(173, 9);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(86, 16);
            this.labelAccount.TabIndex = 3;
            this.labelAccount.Text = "labelAccount";
            // 
            // Spiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 596);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVirensucher);
            this.Controls.Add(this.listBoxProgrammierer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Spiel";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxProgrammierer;
		private System.Windows.Forms.ListBox listBoxVirensucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAccount;
	}
}

