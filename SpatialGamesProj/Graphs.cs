using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using SpatialGames;

namespace SpatialGamesProj
{
    public partial class Graphs : Form
    {
        public int rounds { get; }
        List<Player> playerList = new List<Player>();

        //Using the rounds as the x axis and the scores array found in the player list as a y axis to map the points on the graph
        public Graphs(int rounds,List<Player> players)
        {
            InitializeComponent();
            this.rounds = rounds;
            this.playerList = players;
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            lblGraphX.Text = "Rounds";
            lblGraphY.Text = "Score";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGraphReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private float F(float x)
        {
            return (float)(x);
        }

        private void btnGraphTest_Click(object sender, EventArgs e)
        {
            // The bounds to draw.
            float xmin = 0;
            float xmax = rounds;
            float ymin = -3;
            float ymax = 3;

            // Make the Bitmap.
            int wid = picGraph.ClientSize.Width;
            int hgt = picGraph.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // Transform to map the graph bounds to the Bitmap.
                RectangleF rect = new RectangleF(
                    xmin, ymin, xmax - xmin, ymax - ymin);
                PointF[] pts =
                {
                    new PointF(0, hgt),
                    new PointF(wid, hgt),
                    new PointF(0, 0),
                };
                gr.Transform = new Matrix(rect, pts);

                using (Pen graph_pen = new Pen(Color.Blue, 0))
                {
                    //method to draw the axis
                    gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                    gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                    for (int x = (int)xmin; x <= xmax; x++)
                    {
                        gr.DrawLine(graph_pen, x, -0.1f, x, 0.1f);
                    }
                    for (int y = (int)ymin; y <= ymax; y++)
                    {
                        gr.DrawLine(graph_pen, -0.1f, y, 0.1f, y);
                    }
                    graph_pen.Color = Color.Red;
                    //Take the points from the scores array and the max point from the rounds to plot the points to be drawn
                }
            }
            picGraph.Image = bm;
        }

    }
}