
namespace SpatialGamesProj
{
    partial class Graphs
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
            this.lblGraphX = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.lblGraphY = new System.Windows.Forms.Label();
            this.btnGraphReturn = new System.Windows.Forms.Button();
            this.btnGraphTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGraphX
            // 
            this.lblGraphX.AutoSize = true;
            this.lblGraphX.Location = new System.Drawing.Point(120, 426);
            this.lblGraphX.Name = "lblGraphX";
            this.lblGraphX.Size = new System.Drawing.Size(38, 15);
            this.lblGraphX.TabIndex = 0;
            this.lblGraphX.Text = "label1";
            this.lblGraphX.Click += new System.EventHandler(this.label1_Click);
            // 
            // picGraph
            // 
            this.picGraph.Location = new System.Drawing.Point(120, 12);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(526, 398);
            this.picGraph.TabIndex = 1;
            this.picGraph.TabStop = false;
            // 
            // lblGraphY
            // 
            this.lblGraphY.AutoSize = true;
            this.lblGraphY.Location = new System.Drawing.Point(76, 214);
            this.lblGraphY.Name = "lblGraphY";
            this.lblGraphY.Size = new System.Drawing.Size(38, 15);
            this.lblGraphY.TabIndex = 2;
            this.lblGraphY.Text = "label1";
            // 
            // btnGraphReturn
            // 
            this.btnGraphReturn.Location = new System.Drawing.Point(713, 415);
            this.btnGraphReturn.Name = "btnGraphReturn";
            this.btnGraphReturn.Size = new System.Drawing.Size(75, 23);
            this.btnGraphReturn.TabIndex = 3;
            this.btnGraphReturn.Text = "Go Back";
            this.btnGraphReturn.UseVisualStyleBackColor = true;
            this.btnGraphReturn.Click += new System.EventHandler(this.btnGraphReturn_Click);
            // 
            // btnGraphTest
            // 
            this.btnGraphTest.Location = new System.Drawing.Point(713, 372);
            this.btnGraphTest.Name = "btnGraphTest";
            this.btnGraphTest.Size = new System.Drawing.Size(75, 23);
            this.btnGraphTest.TabIndex = 4;
            this.btnGraphTest.Text = "Graph";
            this.btnGraphTest.UseVisualStyleBackColor = true;
            this.btnGraphTest.Click += new System.EventHandler(this.btnGraphTest_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraphTest);
            this.Controls.Add(this.btnGraphReturn);
            this.Controls.Add(this.lblGraphY);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.lblGraphX);
            this.Name = "Graphs";
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.Graphs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraphX;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Label lblGraphY;
        private System.Windows.Forms.Button btnGraphReturn;
        private System.Windows.Forms.Button btnGraphTest;
    }
}