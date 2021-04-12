using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpatialGamesProj
{
    public partial class SpatialGame : Form
    {
        public SpatialGame(string testStr)
        {
           
            InitializeComponent();
            lblTest2.Text = testStr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Graphs g1 = new Graphs();
            g1.Show();
        }
    }
}
