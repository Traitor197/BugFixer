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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spiel));
			this.label3 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelAccount = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewProgrammierer = new System.Windows.Forms.DataGridView();
			this.dataGridViewVirensucher = new System.Windows.Forms.DataGridView();
			this.buttonKaufen = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewStatistik = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.labelFixes = new System.Windows.Forms.Label();
			this.pictureBoxBug = new System.Windows.Forms.PictureBox();
			this.timerCountSeconds = new System.Windows.Forms.Timer(this.components);
			this.labelStatus = new System.Windows.Forms.Label();
			this.labelFixesProSekunde = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelFixesProKlick = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.timerGridViews = new System.Windows.Forms.Timer(this.components);
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
            this.toolStripStatusLabelAccount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 663);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1290, 42);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelAccount
			// 
			this.toolStripStatusLabelAccount.Name = "toolStripStatusLabelAccount";
			this.toolStripStatusLabelAccount.Size = new System.Drawing.Size(350, 37);
			this.toolStripStatusLabelAccount.Text = "toolStripStatusLabelAccount";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(428, 0);
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
			this.label2.Location = new System.Drawing.Point(849, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 29);
			this.label2.TabIndex = 7;
			this.label2.Text = "Virensucher:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dataGridViewProgrammierer
			// 
			this.dataGridViewProgrammierer.AllowUserToAddRows = false;
			this.dataGridViewProgrammierer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProgrammierer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewProgrammierer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewProgrammierer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProgrammierer.Location = new System.Drawing.Point(424, 34);
			this.dataGridViewProgrammierer.MultiSelect = false;
			this.dataGridViewProgrammierer.Name = "dataGridViewProgrammierer";
			this.dataGridViewProgrammierer.ReadOnly = true;
			this.dataGridViewProgrammierer.RowHeadersVisible = false;
			this.dataGridViewProgrammierer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProgrammierer.Size = new System.Drawing.Size(415, 392);
			this.dataGridViewProgrammierer.TabIndex = 8;
			this.dataGridViewProgrammierer.SelectionChanged += new System.EventHandler(this.dataGridViewProgrammierer_SelectionChanged);
			// 
			// dataGridViewVirensucher
			// 
			this.dataGridViewVirensucher.AllowUserToAddRows = false;
			this.dataGridViewVirensucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewVirensucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewVirensucher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewVirensucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewVirensucher.Location = new System.Drawing.Point(845, 34);
			this.dataGridViewVirensucher.MultiSelect = false;
			this.dataGridViewVirensucher.Name = "dataGridViewVirensucher";
			this.dataGridViewVirensucher.ReadOnly = true;
			this.dataGridViewVirensucher.RowHeadersVisible = false;
			this.dataGridViewVirensucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewVirensucher.Size = new System.Drawing.Size(415, 392);
			this.dataGridViewVirensucher.TabIndex = 9;
			this.dataGridViewVirensucher.SelectionChanged += new System.EventHandler(this.dataGridViewVirensucher_SelectionChanged);
			// 
			// buttonKaufen
			// 
			this.buttonKaufen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonKaufen.Location = new System.Drawing.Point(946, 612);
			this.buttonKaufen.Name = "buttonKaufen";
			this.buttonKaufen.Size = new System.Drawing.Size(332, 43);
			this.buttonKaufen.TabIndex = 11;
			this.buttonKaufen.Text = "kaufen";
			this.buttonKaufen.UseVisualStyleBackColor = true;
			this.buttonKaufen.Click += new System.EventHandler(this.buttonKaufen_Click);
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
			this.dataGridViewStatistik.AllowUserToAddRows = false;
			this.dataGridViewStatistik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStatistik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewStatistik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewStatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStatistik.Location = new System.Drawing.Point(3, 34);
			this.dataGridViewStatistik.MultiSelect = false;
			this.dataGridViewStatistik.Name = "dataGridViewStatistik";
			this.dataGridViewStatistik.ReadOnly = true;
			this.dataGridViewStatistik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewStatistik.Size = new System.Drawing.Size(415, 392);
			this.dataGridViewStatistik.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 609);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 42);
			this.label4.TabIndex = 13;
			this.label4.Text = "Fixes:";
			// 
			// labelFixes
			// 
			this.labelFixes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelFixes.AutoSize = true;
			this.labelFixes.BackColor = System.Drawing.Color.LawnGreen;
			this.labelFixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFixes.Location = new System.Drawing.Point(136, 609);
			this.labelFixes.Name = "labelFixes";
			this.labelFixes.Size = new System.Drawing.Size(95, 42);
			this.labelFixes.TabIndex = 14;
			this.labelFixes.Text = "fixes";
			// 
			// pictureBoxBug
			// 
			this.pictureBoxBug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBoxBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBug.BackgroundImage")));
			this.pictureBoxBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxBug.Location = new System.Drawing.Point(541, 447);
			this.pictureBoxBug.Name = "pictureBoxBug";
			this.pictureBoxBug.Size = new System.Drawing.Size(234, 208);
			this.pictureBoxBug.TabIndex = 15;
			this.pictureBoxBug.TabStop = false;
			this.pictureBoxBug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBug_MouseDown);
			this.pictureBoxBug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBug_MouseUp);
			// 
			// timerCountSeconds
			// 
			this.timerCountSeconds.Interval = 1000;
			this.timerCountSeconds.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.AutoSize = true;
			this.labelStatus.ForeColor = System.Drawing.Color.Red;
			this.labelStatus.Location = new System.Drawing.Point(939, 572);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(175, 37);
			this.labelStatus.TabIndex = 16;
			this.labelStatus.Text = "labelStatus";
			// 
			// labelFixesProSekunde
			// 
			this.labelFixesProSekunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelFixesProSekunde.AutoSize = true;
			this.labelFixesProSekunde.BackColor = System.Drawing.Color.LawnGreen;
			this.labelFixesProSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFixesProSekunde.Location = new System.Drawing.Point(359, 566);
			this.labelFixesProSekunde.Name = "labelFixesProSekunde";
			this.labelFixesProSekunde.Size = new System.Drawing.Size(95, 42);
			this.labelFixesProSekunde.TabIndex = 18;
			this.labelFixesProSekunde.Text = "fixes";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 567);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(341, 42);
			this.label6.TabIndex = 17;
			this.label6.Text = "Fixes pro Sekunde:";
			// 
			// labelFixesProKlick
			// 
			this.labelFixesProKlick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelFixesProKlick.AutoSize = true;
			this.labelFixesProKlick.BackColor = System.Drawing.Color.LawnGreen;
			this.labelFixesProKlick.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFixesProKlick.Location = new System.Drawing.Point(289, 525);
			this.labelFixesProKlick.Name = "labelFixesProKlick";
			this.labelFixesProKlick.Size = new System.Drawing.Size(95, 42);
			this.labelFixesProKlick.TabIndex = 20;
			this.labelFixesProKlick.Text = "fixes";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 525);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(271, 42);
			this.label8.TabIndex = 19;
			this.label8.Text = "Fixes pro Klick:";
			// 
			// timerGridViews
			// 
			this.timerGridViews.Enabled = true;
			this.timerGridViews.Tick += new System.EventHandler(this.timerGridViews_Tick);
			// 
			// Spiel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1290, 705);
			this.Controls.Add(this.labelFixesProKlick);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labelFixesProSekunde);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.pictureBoxBug);
			this.Controls.Add(this.labelFixes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonKaufen);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProgrammierer;
        private System.Windows.Forms.DataGridView dataGridViewVirensucher;
        private System.Windows.Forms.Button buttonKaufen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewStatistik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFixes;
        private System.Windows.Forms.PictureBox pictureBoxBug;
        private System.Windows.Forms.Timer timerCountSeconds;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelFixesProSekunde;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelFixesProKlick;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Timer timerGridViews;
	}
}

