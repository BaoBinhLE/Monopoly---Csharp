using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class formInfoGare : Form
    {

        public formInfoGare(string nomGare)
        {
            InitializeComponent();
            this.Text = nomGare;
            label9.Text = nomGare;
        }

        private void formInfoGare_Load(object sender, EventArgs e)
        {

        }

        
    }
}
