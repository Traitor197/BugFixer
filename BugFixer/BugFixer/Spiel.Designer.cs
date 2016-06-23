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
			this.label3 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewProgrammierer = new System.Windows.Forms.DataGridView();
			this.dataGridViewVirensucher = new System.Windows.Forms.DataGridView();
			this.buttonVerbessern = new System.Windows.Forms.Button();
			this.buttonKaufen = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewStatistik = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.labelFixes = new System.Windows.Forms.Label();
			this.pictureBoxBug = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammierer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewVirensucher)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistik)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBug)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Silver;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 31);
			this.label3.TabIndex = 4;
			this.label3.Text = "Statistik:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 663);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1290, 42);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(350, 37);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabelAccount";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(424, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Programmierer:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Silver;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(874, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "Virensucher:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dataGridViewProgrammierer
			// 
			this.dataGridViewProgrammierer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProgrammierer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewProgrammierer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewProgrammierer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProgrammierer.Location = new System.Drawing.Point(420, 34);
			this.dataGridViewProgrammierer.Name = "dataGridViewProgrammierer";
			this.dataGridViewProgrammierer.ReadOnly = true;
			this.dataGridViewProgrammierer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProgrammierer.Size = new System.Drawing.Size(444, 392);
			this.dataGridViewProgrammierer.TabIndex = 8;
			this.dataGridViewProgrammierer.SelectionChanged += new System.EventHandler(this.dataGridViewProgrammierer_SelectionChanged);
			// 
			// dataGridViewVirensucher
			// 
			this.dataGridViewVirensucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewVirensucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewVirensucher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewVirensucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewVirensucher.Location = new System.Drawing.Point(873, 34);
			this.dataGridViewVirensucher.Name = "dataGridViewVirensucher";
			this.dataGridViewVirensucher.ReadOnly = true;
			this.dataGridViewVirensucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewVirensucher.Size = new System.Drawing.Size(390, 392);
			this.dataGridViewVirensucher.TabIndex = 9;
			this.dataGridViewVirensucher.SelectionChanged += new System.EventHandler(this.dataGridViewVirensucher_SelectionChanged);
			// 
			// buttonVerbessern
			// 
			this.buttonVerbessern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonVerbessern.Location = new System.Drawing.Point(1089, 612);
			this.buttonVerbessern.Name = "buttonVerbessern";
			this.buttonVerbessern.Size = new System.Drawing.Size(189, 43);
			this.buttonVerbessern.TabIndex = 10;
			this.buttonVerbessern.Text = "verbessern";
			this.buttonVerbessern.UseVisualStyleBackColor = true;
			// 
			// buttonKaufen
			// 
			this.buttonKaufen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonKaufen.Location = new System.Drawing.Point(946, 612);
			this.buttonKaufen.Name = "buttonKaufen";
			this.buttonKaufen.Size = new System.Drawing.Size(137, 43);
			this.buttonKaufen.TabIndex = 11;
			this.buttonKaufen.Text = "kaufen";
			this.buttonKaufen.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewProgrammierer, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewStatistik, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewVirensucher, 2, 1);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1263, 429);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// dataGridViewStatistik
			// 
			this.dataGridViewStatistik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStatistik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewStatistik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewStatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStatistik.Location = new System.Drawing.Point(3, 34);
			this.dataGridViewStatistik.Name = "dataGridViewStatistik";
			this.dataGridViewStatistik.ReadOnly = true;
			this.dataGridViewStatistik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewStatistik.Size = new System.Drawing.Size(411, 392);
			this.dataGridViewStatistik.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 618);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 37);
			this.label4.TabIndex = 13;
			this.label4.Text = "Fixes:";
			// 
			// labelFixes
			// 
			this.labelFixes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelFixes.AutoSize = true;
			this.labelFixes.BackColor = System.Drawing.Color.LawnGreen;
			this.labelFixes.Location = new System.Drawing.Point(119, 618);
			this.labelFixes.Name = "labelFixes";
			this.labelFixes.Size = new System.Drawing.Size(81, 37);
			this.labelFixes.TabIndex = 14;
			this.labelFixes.Text = "fixes";
			// 
			// pictureBoxBug
			// 
			this.pictureBoxBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBug.BackgroundImage")));
			this.pictureBoxBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxBug.Location = new System.Drawing.Point(541, 447);
			this.pictureBoxBug.Name = "pictureBoxBug";
			this.pictureBoxBug.Size = new System.Drawing.Size(234, 208);
			this.pictureBoxBug.TabIndex = 15;
			this.pictureBoxBug.TabStop = false;
			this.pictureBoxBug.Click += new System.EventHandler(this.pictureBoxBug_Click);
			// 
			// Spiel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1290, 705);
			this.Controls.Add(this.pictureBoxBug);
			this.Controls.Add(this.labelFixes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonKaufen);
			this.Controls.Add(this.buttonVerbessern);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(10);
			this.Name = "Spiel";
			this.Text = "BugFixer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Spiel_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgrammierer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewVirensucher)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistik)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBug)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProgrammierer;
        private System.Windows.Forms.DataGridView dataGridViewVirensucher;
        private System.Windows.Forms.Button buttonVerbessern;
        private System.Windows.Forms.Button buttonKaufen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewStatistik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFixes;
        private System.Windows.Forms.PictureBox pictureBoxBug;
	}
}

