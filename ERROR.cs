using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roboping
{
    
    public partial class ERROR : Form
    {
        public static ERROR instance;

        public ERROR()
        {
            InitializeComponent();
            instance = this;
        }

        private void DONE2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void showdialog()
        {
            ERROR msg1 = new ERROR();
            msg1.Show();
        }

        private void ERROR_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void errortext_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null; // This will move focus away from the TextBox
        }
    }
}
