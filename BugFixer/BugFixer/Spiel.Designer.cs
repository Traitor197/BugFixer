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
            this.dataGridViewProgrammierer = new System.Windows.Forms.DataGridView();
            this.dataGridViewVirensucher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammierer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVirensucher)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProgrammierer
            // 
            this.dataGridViewProgrammierer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgrammierer.Location = new System.Drawing.Point(29, 35);
            this.dataGridViewProgrammierer.Name = "dataGridViewProgrammierer";
            this.dataGridViewProgrammierer.Size = new System.Drawing.Size(517, 416);
            this.dataGridViewProgrammierer.TabIndex = 2;
            // 
            // dataGridViewVirensucher
            // 
            this.dataGridViewVirensucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVirensucher.Location = new System.Drawing.Point(580, 40);
            this.dataGridViewVirensucher.Name = "dataGridViewVirensucher";
            this.dataGridViewVirensucher.Size = new System.Drawing.Size(654, 429);
            this.dataGridViewVirensucher.TabIndex = 3;
            // 
            // Spiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 635);
            this.Controls.Add(this.dataGridViewVirensucher);
            this.Controls.Add(this.dataGridViewProgrammierer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Spiel";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammierer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVirensucher)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.DataGridView dataGridViewProgrammierer;
        private System.Windows.Forms.DataGridView dataGridViewVirensucher;
	}
}

