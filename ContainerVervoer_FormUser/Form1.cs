using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer_FormUser
{
    public partial class Form1 : Form
    {
        public int length;
        public int width;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            length = Convert.ToInt32(Nud_Length.Text);
            width = Convert.ToInt32(Nud_Width.Text);
            if (length > 9 || width > 9)
            {
                MessageBox.Show("The max value of length or width is 9.\nPlease use smaller numbers.");
            }
            else
            {
                MessageBox.Show("Length = " + length + " Width = " + width);
            }
        }
    }
}
