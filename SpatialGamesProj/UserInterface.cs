using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpatialGamesProj
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String radioStrategy = "";

            if(radioScatter.Checked == true)
            {
                radioStrategy = "Scatter";
            }
            else if(radioBlock.Checked == true)
            {
                radioStrategy = "Block";
            }
            else if (radioRows.Checked == true)
            {
                radioStrategy = "Rows";
            }
            else if (radioRandom.Checked == true)
            {
                radioStrategy = "Random";
            }


            lblInit.Text = "Initialised";
            SpatialGame f2 = new SpatialGame(txtTest.Text,Int32.Parse(txtGrid.Text), Int32.Parse(txtCoop.Text), Int32.Parse(txtDefect.Text), Int32.Parse(txtTitForTat.Text),radioStrategy);
            f2.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
