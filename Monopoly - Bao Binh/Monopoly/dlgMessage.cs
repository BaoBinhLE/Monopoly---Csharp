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
    public partial class dlgMessage : Form
    {
        public dlgMessage(string txt1, string txt2)
        {
            InitializeComponent();
            label1.Text = txt1;
            label2.Text = txt2;
        }

        private void dlgMessage_Load(object sender, EventArgs e)
        {
            this.Click += new EventHandler(clic);
            label1.Click += new EventHandler(clic);
            label2.Click += new EventHandler(clic);
        }

        private void clic(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
