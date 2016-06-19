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
			this.listBoxProgrammierer = new System.Windows.Forms.ListBox();
			this.listBoxVirensucher = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBoxProgrammierer
			// 
			this.listBoxProgrammierer.FormattingEnabled = true;
			this.listBoxProgrammierer.ItemHeight = 16;
			this.listBoxProgrammierer.Location = new System.Drawing.Point(12, 12);
			this.listBoxProgrammierer.Name = "listBoxProgrammierer";
			this.listBoxProgrammierer.Size = new System.Drawing.Size(302, 212);
			this.listBoxProgrammierer.TabIndex = 0;
			// 
			// listBoxVirensucher
			// 
			this.listBoxVirensucher.FormattingEnabled = true;
			this.listBoxVirensucher.ItemHeight = 16;
			this.listBoxVirensucher.Location = new System.Drawing.Point(320, 12);
			this.listBoxVirensucher.Name = "listBoxVirensucher";
			this.listBoxVirensucher.Size = new System.Drawing.Size(366, 212);
			this.listBoxVirensucher.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 596);
			this.Controls.Add(this.listBoxVirensucher);
			this.Controls.Add(this.listBoxProgrammierer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxProgrammierer;
		private System.Windows.Forms.ListBox listBoxVirensucher;
	}
}

