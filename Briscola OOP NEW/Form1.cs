using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Briscola_OOP_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Image\Campo.jpg"))
            {
                Image sfondo = new Bitmap(@"Image\Campo.jpg");
                this.BackgroundImage = sfondo;
            }

            this.Size = new Size(900, 500);
            button1.Visible = false;
            button3.Visible = false;
            button2.Location = new Point(750, 400);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
