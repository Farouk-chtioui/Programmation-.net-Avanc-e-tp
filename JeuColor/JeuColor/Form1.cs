using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            EnableAllButtons();
            btn_blue.Enabled = false;
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            EnableAllButtons();
            btn_green.Enabled = false;
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
            EnableAllButtons();
            btn_default.Enabled = false;
        }

        private void EnableAllButtons()
        {
            btn_blue.Enabled = true;
            btn_green.Enabled = true;
            btn_default.Enabled = true;
        }
    }
}
