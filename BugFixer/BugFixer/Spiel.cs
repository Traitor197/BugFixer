using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugFixer
{
	public partial class Spiel : Form
	{
		public Spiel()
		{
			InitializeComponent();
            this.FormClosing += Closing;
		}

        private void Closing(object sender, EventArgs e)
        {
            
        }
	}
}
