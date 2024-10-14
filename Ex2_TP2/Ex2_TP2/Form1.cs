using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            if (lbl_displayText.Visible)
            {
                lbl_displayText.Visible = false;
                btn_text.Text = "Show";
            }
            else
            {
                lbl_displayText.Text = "The button was clicked!";
                lbl_displayText.Visible = true;
                btn_text.Text = "Don't show";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}