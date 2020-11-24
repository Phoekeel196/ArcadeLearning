using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ArcadeLearning
{
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Start_Click_2(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(500);
            Start.ForeColor = Color.Black;   

            Refresh();
            Thread.Sleep(500);
            Number3.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(750);
            Number3.ForeColor = Color.Black;

            Refresh();
            Thread.Sleep(500);
            Number2.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(750);
            Number2.ForeColor = Color.Black;

            Refresh();
            Thread.Sleep(500);
            Number1.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(500);
            Number1.ForeColor = Color.Black;

            Refresh();
            Thread.Sleep(500);
            Start.ForeColor = Color.Green;
            Start.BackColor = Color.Green;
            Edge1.BackColor = Color.Green;
            Edge2.BackColor = Color.Green;
            Number3.BackColor = Color.Green;
            Number3.ForeColor = Color.Green;
            Number2.BackColor = Color.Green;
            Number2.ForeColor = Color.Green;
            Number1.ForeColor = Color.Green;
            Number1.BackColor = Color.Green;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
