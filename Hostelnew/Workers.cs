using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostelnew
{
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            workerspage wrkp = new workerspage();
            wrkp.ShowDialog();
        }
    }
}
