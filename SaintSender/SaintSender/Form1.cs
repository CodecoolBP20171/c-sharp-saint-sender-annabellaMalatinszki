using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            letterPicture.ImageLocation = "C:\\Users\\amala\\Documents\\Codecool\\C#\\TW_assignments\\c-sharp-saint-sender-annabellaMalatinszki\\SaintSender\\letter.png";
            letterPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
