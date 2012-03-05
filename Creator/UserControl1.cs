using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creator
{
    public partial class UserControl1 : UserControl
    {
        public int Maximum
        {
            get { return progressBar1.Maximum; }
            set { progressBar1.Maximum = value; }
        }
        public int Value
        {
            get { return progressBar1.Value; }
            set { progressBar1.Value = value;
            label1.Text = progressBar1.Value*100/progressBar1.Maximum+"% processing...";
            }
        }

        public int Step
        {
            get { return progressBar1.Step; }
            set { progressBar1.Step = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        public void PerformStep()
        {
            progressBar1.PerformStep();
            label1.Text = progressBar1.Value * 100 / progressBar1.Maximum + "% processing...";
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            int gLeft = panel1.Width / 2 - label1.Width / 2; //this指Form
            //int gTop = panel1.Height / 2 - label1.Height * 2;
            label1.Left = gLeft;
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            this.Height = 60;
        }
    }
}
