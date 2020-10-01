using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.LostFocus += Form2_LostFocus;
        }

        private void Form2_LostFocus(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
