
namespace SpatialGamesProj
{
    partial class UserInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInit = new System.Windows.Forms.Button();
            this.txtGrid = new System.Windows.Forms.TextBox();
            this.Strategies = new System.Windows.Forms.ListBox();
            this.txtCoop = new System.Windows.Forms.TextBox();
            this.txtDefect = new System.Windows.Forms.TextBox();
            this.txtTitForTat = new System.Windows.Forms.TextBox();
            this.StrategyArrangements = new System.Windows.Forms.ListBox();
            this.radioScatter = new System.Windows.Forms.RadioButton();
            this.radioBlock = new System.Windows.Forms.RadioButton();
            this.radioRows = new System.Windows.Forms.RadioButton();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInit = new System.Windows.Forms.Label();
            this.txtGameLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioRBlock = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(633, 364);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 6;
            this.btnInit.Text = "Initialise";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtGrid
            // 
            this.txtGrid.Location = new System.Drawing.Point(119, 48);
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.Size = new System.Drawing.Size(100, 23);
            this.txtGrid.TabIndex = 7;
            this.txtGrid.TextChanged += new System.EventHandler(this.txtGrid_TextChanged);
            // 
            // Strategies
            // 
            this.Strategies.FormattingEnabled = true;
            this.Strategies.ItemHeight = 15;
            this.Strategies.Location = new System.Drawing.Point(27, 168);
            this.Strategies.Name = "Strategies";
            this.Strategies.Size = new System.Drawing.Size(247, 199);
            this.Strategies.TabIndex = 8;
            this.Strategies.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtCoop
            // 
            this.txtCoop.Location = new System.Drawing.Point(119, 204);
            this.txtCoop.Name = "txtCoop";
            this.txtCoop.Size = new System.Drawing.Size(100, 23);
            this.txtCoop.TabIndex = 9;
            // 
            // txtDefect
            // 
            this.txtDefect.Location = new System.Drawing.Point(119, 233);
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(100, 23);
            this.txtDefect.TabIndex = 10;
            // 
            // txtTitForTat
            // 
            this.txtTitForTat.Location = new System.Drawing.Point(119, 265);
            this.txtTitForTat.Name = "txtTitForTat";
            this.txtTitForTat.Size = new System.Drawing.Size(100, 23);
            this.txtTitForTat.TabIndex = 11;
            // 
            // StrategyArrangements
            // 
            this.StrategyArrangements.FormattingEnabled = true;
            this.StrategyArrangements.ItemHeight = 15;
            this.StrategyArrangements.Location = new System.Drawing.Point(353, 48);
            this.StrategyArrangements.Name = "StrategyArrangements";
            this.StrategyArrangements.Size = new System.Drawing.Size(393, 154);
            this.StrategyArrangements.TabIndex = 13;
            this.StrategyArrangements.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // radioScatter
            // 
            this.radioScatter.AutoSize = true;
            this.radioScatter.Location = new System.Drawing.Point(369, 70);
            this.radioScatter.Name = "radioScatter";
            this.radioScatter.Size = new System.Drawing.Size(61, 19);
            this.radioScatter.TabIndex = 14;
            this.radioScatter.TabStop = true;
            this.radioScatter.Text = "Scatter";
            this.radioScatter.UseVisualStyleBackColor = true;
            // 
            // radioBlock
            // 
            this.radioBlock.AutoSize = true;
            this.radioBlock.Location = new System.Drawing.Point(369, 95);
            this.radioBlock.Name = "radioBlock";
            this.radioBlock.Size = new System.Drawing.Size(54, 19);
            this.radioBlock.TabIndex = 15;
            this.radioBlock.TabStop = true;
            this.radioBlock.Text = "Block";
            this.radioBlock.UseVisualStyleBackColor = true;
            this.radioBlock.CheckedChanged += new System.EventHandler(this.radioBlock_CheckedChanged);
            // 
            // radioRows
            // 
            this.radioRows.AutoSize = true;
            this.radioRows.Location = new System.Drawing.Point(369, 145);
            this.radioRows.Name = "radioRows";
            this.radioRows.Size = new System.Drawing.Size(53, 19);
            this.radioRows.TabIndex = 16;
            this.radioRows.TabStop = true;
            this.radioRows.Text = "Rows";
            this.radioRows.UseVisualStyleBackColor = true;
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(369, 170);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(70, 19);
            this.radioRandom.TabIndex = 17;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Random";
            this.radioRandom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cooperators";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Defectors";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "TitForTat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Grid Size";
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(495, 368);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(38, 15);
            this.lblInit.TabIndex = 22;
            this.lblInit.Text = "label5";
            // 
            // txtGameLength
            // 
            this.txtGameLength.Location = new System.Drawing.Point(119, 77);
            this.txtGameLength.Name = "txtGameLength";
            this.txtGameLength.Size = new System.Drawing.Size(100, 23);
            this.txtGameLength.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Game length";
            // 
            // radioRBlock
            // 
            this.radioRBlock.AutoSize = true;
            this.radioRBlock.Location = new System.Drawing.Point(369, 120);
            this.radioRBlock.Name = "radioRBlock";
            this.radioRBlock.Size = new System.Drawing.Size(97, 19);
            this.radioRBlock.TabIndex = 25;
            this.radioRBlock.TabStop = true;
            this.radioRBlock.Text = "Reverse Block";
            this.radioRBlock.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioRBlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGameLength);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioRandom);
            this.Controls.Add(this.radioRows);
            this.Controls.Add(this.radioBlock);
            this.Controls.Add(this.radioScatter);
            this.Controls.Add(this.StrategyArrangements);
            this.Controls.Add(this.txtTitForTat);
            this.Controls.Add(this.txtDefect);
            this.Controls.Add(this.txtCoop);
            this.Controls.Add(this.Strategies);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.btnInit);
            this.Name = "UserInterface";
            this.Text = "UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtGrid;
        private System.Windows.Forms.ListBox Strategies;
        private System.Windows.Forms.TextBox txtCoop;
        private System.Windows.Forms.TextBox txtDefect;
        private System.Windows.Forms.TextBox txtTitForTat;
        private System.Windows.Forms.ListBox StrategyArrangements;
        private System.Windows.Forms.RadioButton radioScatter;
        private System.Windows.Forms.RadioButton radioBlock;
        private System.Windows.Forms.RadioButton radioRows;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.TextBox txtGameLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioRBlock;
    }
}

