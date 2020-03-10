using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velichko1
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(metroTextBox1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            metroTextBox1.Text = e.KeyData.ToString();
        }
    }
}
