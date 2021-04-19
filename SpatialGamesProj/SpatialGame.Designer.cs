
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
            this.lblTest2 = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.lblCoop = new System.Windows.Forms.Label();
            this.lblDefect = new System.Windows.Forms.Label();
            this.lblTitForTat = new System.Windows.Forms.Label();
            this.lblArrange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(377, 203);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(38, 15);
            this.lblTest2.TabIndex = 0;
            this.lblTest2.Text = "label1";
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(713, 415);
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
            this.lblRounds.Location = new System.Drawing.Point(713, 32);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(54, 15);
            this.lblRounds.TabIndex = 2;
            this.lblRounds.Text = "Round: 0";
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(251, 252);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(38, 15);
            this.lblGrid.TabIndex = 3;
            this.lblGrid.Text = "label1";
            // 
            // lblCoop
            // 
            this.lblCoop.AutoSize = true;
            this.lblCoop.Location = new System.Drawing.Point(303, 252);
            this.lblCoop.Name = "lblCoop";
            this.lblCoop.Size = new System.Drawing.Size(38, 15);
            this.lblCoop.TabIndex = 4;
            this.lblCoop.Text = "label1";
            // 
            // lblDefect
            // 
            this.lblDefect.AutoSize = true;
            this.lblDefect.Location = new System.Drawing.Point(357, 252);
            this.lblDefect.Name = "lblDefect";
            this.lblDefect.Size = new System.Drawing.Size(38, 15);
            this.lblDefect.TabIndex = 5;
            this.lblDefect.Text = "label1";
            // 
            // lblTitForTat
            // 
            this.lblTitForTat.AutoSize = true;
            this.lblTitForTat.Location = new System.Drawing.Point(412, 252);
            this.lblTitForTat.Name = "lblTitForTat";
            this.lblTitForTat.Size = new System.Drawing.Size(38, 15);
            this.lblTitForTat.TabIndex = 6;
            this.lblTitForTat.Text = "label1";
            // 
            // lblArrange
            // 
            this.lblArrange.AutoSize = true;
            this.lblArrange.Location = new System.Drawing.Point(469, 252);
            this.lblArrange.Name = "lblArrange";
            this.lblArrange.Size = new System.Drawing.Size(38, 15);
            this.lblArrange.TabIndex = 7;
            this.lblArrange.Text = "label1";
            // 
            // SpatialGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArrange);
            this.Controls.Add(this.lblTitForTat);
            this.Controls.Add(this.lblDefect);
            this.Controls.Add(this.lblCoop);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.lblTest2);
            this.Name = "SpatialGame";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblCoop;
        private System.Windows.Forms.Label lblDefect;
        private System.Windows.Forms.Label lblTitForTat;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblArrange;
    }
}