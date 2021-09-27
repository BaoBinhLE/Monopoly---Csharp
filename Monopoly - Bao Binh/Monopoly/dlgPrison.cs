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
    public partial class dlgPrison : Form
    {
        private bool carteGratuit;
        private bool assezArgent;
        public dlgPrison(bool carteGratuit, bool assezArgent)
        {
            InitializeComponent();
            this.carteGratuit = carteGratuit;
            this.assezArgent = assezArgent;
        }

        private void dlgPrison_Load(object sender, EventArgs e)
        {
            if (carteGratuit)
            {
                button3.Enabled = true;
            }
            button2.Enabled = assezArgent;
        }
    }
}
