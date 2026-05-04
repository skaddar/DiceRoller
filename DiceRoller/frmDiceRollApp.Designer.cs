using System.Drawing;

namespace DiceRoller
{
    partial class frmDiceRollApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiceRollApp));
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotalRolls = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblFreqHeader = new System.Windows.Forms.Label();
            this.lblFreq1 = new System.Windows.Forms.Label();
            this.lblFreq2 = new System.Windows.Forms.Label();
            this.lblFreq3 = new System.Windows.Forms.Label();
            this.lblFreq4 = new System.Windows.Forms.Label();
            this.lblFreq5 = new System.Windows.Forms.Label();
            this.lblFreq6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRoll.FlatAppearance.BorderSize = 2;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(266, 23);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(147, 52);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPickUp.FlatAppearance.BorderSize = 2;
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickUp.Location = new System.Drawing.Point(533, 23);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(147, 52);
            this.btnPickUp.TabIndex = 1;
            this.btnPickUp.Text = "Pick up";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // picDice
            // 
            this.picDice.BackColor = System.Drawing.Color.LightGray;
            this.picDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDice.Location = new System.Drawing.Point(346, 125);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(250, 250);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDice.TabIndex = 2;
            this.picDice.TabStop = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlStats.Controls.Add(this.lblTotalRolls);
            this.pnlStats.Controls.Add(this.lblAverage);
            this.pnlStats.Controls.Add(this.lblFreqHeader);
            this.pnlStats.Controls.Add(this.lblFreq1);
            this.pnlStats.Controls.Add(this.lblFreq2);
            this.pnlStats.Controls.Add(this.lblFreq3);
            this.pnlStats.Controls.Add(this.lblFreq4);
            this.pnlStats.Controls.Add(this.lblFreq5);
            this.pnlStats.Controls.Add(this.lblFreq6);
            this.pnlStats.Location = new System.Drawing.Point(753, 186);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(200, 280);
            this.pnlStats.TabIndex = 4;
            // 
            // lblTotalRolls
            // 
            this.lblTotalRolls.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRolls.ForeColor = System.Drawing.Color.White;
            this.lblTotalRolls.Location = new System.Drawing.Point(10, 10);
            this.lblTotalRolls.Name = "lblTotalRolls";
            this.lblTotalRolls.Size = new System.Drawing.Size(180, 20);
            this.lblTotalRolls.TabIndex = 0;
            this.lblTotalRolls.Text = "Total Rolls: 0";
            // 
            // lblAverage
            // 
            this.lblAverage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverage.ForeColor = System.Drawing.Color.White;
            this.lblAverage.Location = new System.Drawing.Point(10, 35);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(180, 20);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Average: 0.00";
            // 
            // lblFreqHeader
            // 
            this.lblFreqHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFreqHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblFreqHeader.Location = new System.Drawing.Point(10, 65);
            this.lblFreqHeader.Name = "lblFreqHeader";
            this.lblFreqHeader.Size = new System.Drawing.Size(180, 20);
            this.lblFreqHeader.TabIndex = 2;
            this.lblFreqHeader.Text = "Frequency:";
            // 
            // lblFreq1
            // 
            this.lblFreq1.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq1.ForeColor = System.Drawing.Color.White;
            this.lblFreq1.Location = new System.Drawing.Point(10, 90);
            this.lblFreq1.Name = "lblFreq1";
            this.lblFreq1.Size = new System.Drawing.Size(180, 20);
            this.lblFreq1.TabIndex = 3;
            this.lblFreq1.Text = "1: 0  (0%)";
            // 
            // lblFreq2
            // 
            this.lblFreq2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq2.ForeColor = System.Drawing.Color.White;
            this.lblFreq2.Location = new System.Drawing.Point(10, 115);
            this.lblFreq2.Name = "lblFreq2";
            this.lblFreq2.Size = new System.Drawing.Size(180, 20);
            this.lblFreq2.TabIndex = 4;
            this.lblFreq2.Text = "2: 0  (0%)";
            // 
            // lblFreq3
            // 
            this.lblFreq3.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq3.ForeColor = System.Drawing.Color.White;
            this.lblFreq3.Location = new System.Drawing.Point(10, 140);
            this.lblFreq3.Name = "lblFreq3";
            this.lblFreq3.Size = new System.Drawing.Size(180, 20);
            this.lblFreq3.TabIndex = 5;
            this.lblFreq3.Text = "3: 0  (0%)";
            // 
            // lblFreq4
            // 
            this.lblFreq4.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq4.ForeColor = System.Drawing.Color.White;
            this.lblFreq4.Location = new System.Drawing.Point(10, 165);
            this.lblFreq4.Name = "lblFreq4";
            this.lblFreq4.Size = new System.Drawing.Size(180, 20);
            this.lblFreq4.TabIndex = 6;
            this.lblFreq4.Text = "4: 0  (0%)";
            // 
            // lblFreq5
            // 
            this.lblFreq5.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq5.ForeColor = System.Drawing.Color.White;
            this.lblFreq5.Location = new System.Drawing.Point(10, 190);
            this.lblFreq5.Name = "lblFreq5";
            this.lblFreq5.Size = new System.Drawing.Size(180, 20);
            this.lblFreq5.TabIndex = 7;
            this.lblFreq5.Text = "5: 0  (0%)";
            // 
            // lblFreq6
            // 
            this.lblFreq6.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFreq6.ForeColor = System.Drawing.Color.White;
            this.lblFreq6.Location = new System.Drawing.Point(10, 215);
            this.lblFreq6.Name = "lblFreq6";
            this.lblFreq6.Size = new System.Drawing.Size(180, 20);
            this.lblFreq6.TabIndex = 8;
            this.lblFreq6.Text = "6: 0  (0%)";
            // 
            // frmDiceRollApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 469);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pnlStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiceRollApp";
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotalRolls;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFreqHeader;
        private System.Windows.Forms.Label lblFreq1;
        private System.Windows.Forms.Label lblFreq2;
        private System.Windows.Forms.Label lblFreq3;
        private System.Windows.Forms.Label lblFreq4;
        private System.Windows.Forms.Label lblFreq5;
        private System.Windows.Forms.Label lblFreq6;
    }
}

