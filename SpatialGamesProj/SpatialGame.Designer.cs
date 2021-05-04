
namespace SpatialGamesProj
{
    partial class SpatialGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.lblCoop = new System.Windows.Forms.Label();
            this.lblDefect = new System.Windows.Forms.Label();
            this.lblTitForTat = new System.Windows.Forms.Label();
            this.lblArrange = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTwoX = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltestScore = new System.Windows.Forms.Label();
            this.lbltestScore2 = new System.Windows.Forms.Label();
            this.lbltestScore3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(155, 445);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(38, 15);
            this.lblTest2.TabIndex = 0;
            this.lblTest2.Text = "label1";
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(813, 445);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 1;
            this.btnGraph.Text = "Graphs";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(824, 9);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(54, 15);
            this.lblRounds.TabIndex = 2;
            this.lblRounds.Text = "Round: 0";
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(277, 445);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(38, 15);
            this.lblGrid.TabIndex = 3;
            this.lblGrid.Text = "label1";
            // 
            // lblCoop
            // 
            this.lblCoop.AutoSize = true;
            this.lblCoop.Location = new System.Drawing.Point(329, 445);
            this.lblCoop.Name = "lblCoop";
            this.lblCoop.Size = new System.Drawing.Size(38, 15);
            this.lblCoop.TabIndex = 4;
            this.lblCoop.Text = "label1";
            // 
            // lblDefect
            // 
            this.lblDefect.AutoSize = true;
            this.lblDefect.Location = new System.Drawing.Point(383, 445);
            this.lblDefect.Name = "lblDefect";
            this.lblDefect.Size = new System.Drawing.Size(38, 15);
            this.lblDefect.TabIndex = 5;
            this.lblDefect.Text = "label1";
            // 
            // lblTitForTat
            // 
            this.lblTitForTat.AutoSize = true;
            this.lblTitForTat.Location = new System.Drawing.Point(438, 445);
            this.lblTitForTat.Name = "lblTitForTat";
            this.lblTitForTat.Size = new System.Drawing.Size(38, 15);
            this.lblTitForTat.TabIndex = 6;
            this.lblTitForTat.Text = "label1";
            // 
            // lblArrange
            // 
            this.lblArrange.AutoSize = true;
            this.lblArrange.Location = new System.Drawing.Point(495, 445);
            this.lblArrange.Name = "lblArrange";
            this.lblArrange.Size = new System.Drawing.Size(38, 15);
            this.lblArrange.TabIndex = 7;
            this.lblArrange.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(813, 387);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(813, 416);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTwoX
            // 
            this.btnTwoX.Location = new System.Drawing.Point(796, 27);
            this.btnTwoX.Name = "btnTwoX";
            this.btnTwoX.Size = new System.Drawing.Size(43, 23);
            this.btnTwoX.TabIndex = 10;
            this.btnTwoX.Text = ">>";
            this.btnTwoX.UseVisualStyleBackColor = true;
            this.btnTwoX.Click += new System.EventHandler(this.btnTwoX_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = ">>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbltestScore
            // 
            this.lbltestScore.AutoSize = true;
            this.lbltestScore.Location = new System.Drawing.Point(824, 81);
            this.lbltestScore.Name = "lbltestScore";
            this.lbltestScore.Size = new System.Drawing.Size(38, 15);
            this.lbltestScore.TabIndex = 12;
            this.lbltestScore.Text = "label1";
            // 
            // lbltestScore2
            // 
            this.lbltestScore2.AutoSize = true;
            this.lbltestScore2.Location = new System.Drawing.Point(824, 109);
            this.lbltestScore2.Name = "lbltestScore2";
            this.lbltestScore2.Size = new System.Drawing.Size(38, 15);
            this.lbltestScore2.TabIndex = 13;
            this.lbltestScore2.Text = "label1";
            this.lbltestScore2.Click += new System.EventHandler(this.lbltestScore2_Click);
            // 
            // lbltestScore3
            // 
            this.lbltestScore3.AutoSize = true;
            this.lbltestScore3.Location = new System.Drawing.Point(824, 137);
            this.lbltestScore3.Name = "lbltestScore3";
            this.lbltestScore3.Size = new System.Drawing.Size(38, 15);
            this.lbltestScore3.TabIndex = 14;
            this.lbltestScore3.Text = "label1";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(813, 325);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(824, 219);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(38, 15);
            this.lblTest.TabIndex = 16;
            this.lblTest.Text = "label1";
            // 
            // SpatialGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbltestScore3);
            this.Controls.Add(this.lbltestScore2);
            this.Controls.Add(this.lbltestScore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTwoX);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblArrange);
            this.Controls.Add(this.lblTitForTat);
            this.Controls.Add(this.lblDefect);
            this.Controls.Add(this.lblCoop);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.lblTest2);
            this.Name = "SpatialGame";
            this.Text = "Spatial Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblCoop;
        private System.Windows.Forms.Label lblDefect;
        private System.Windows.Forms.Label lblTitForTat;
        private System.Windows.Forms.Label lblArrange;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTwoX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltestScore;
        private System.Windows.Forms.Label lbltestScore2;
        private System.Windows.Forms.Label lbltestScore3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
    }
}