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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcImage.Image = new Bitmap(@"C:\Users\User\source\repos\Hostelnew\Hostelnew\image\images.jfif");
            pcImage.Location=new Point((this.ClientSize.Width-pcImage.Size.Width)/2,
                (this.ClientSize.Height-pcImage.Size.Height)/2);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnworkers_Click(object sender, EventArgs e)
        {
            Workers wk = new Workers();
            wk.ShowDialog();

        }

        private void Btnadmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.ShowDialog();
        }
    }
}
