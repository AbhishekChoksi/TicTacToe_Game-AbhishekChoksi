
namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTic9 = new System.Windows.Forms.Button();
            this.btnTic6 = new System.Windows.Forms.Button();
            this.btnTic3 = new System.Windows.Forms.Button();
            this.btnTic8 = new System.Windows.Forms.Button();
            this.btnTic5 = new System.Windows.Forms.Button();
            this.btnTic7 = new System.Windows.Forms.Button();
            this.btnTic4 = new System.Windows.Forms.Button();
            this.btnTic2 = new System.Windows.Forms.Button();
            this.btnTic1 = new System.Windows.Forms.Button();
            this.lblHigh = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHigh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe Game";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 558);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(763, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 522);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnNewGame);
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.btnReset);
            this.panel6.Location = new System.Drawing.Point(3, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 250);
            this.panel6.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(3, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(546, 120);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(276, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(273, 120);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(273, 120);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblPlayerO);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblPlayerX);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 227);
            this.panel5.TabIndex = 0;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.BackColor = System.Drawing.Color.White;
            this.lblPlayerO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerO.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerO.Location = new System.Drawing.Point(293, 125);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(254, 73);
            this.lblPlayerO.TabIndex = 0;
            this.lblPlayerO.Text = "0";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player O:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.BackColor = System.Drawing.Color.White;
            this.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerX.Location = new System.Drawing.Point(293, 25);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(254, 73);
            this.lblPlayerX.TabIndex = 0;
            this.lblPlayerX.Text = "0";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTic9);
            this.panel3.Controls.Add(this.btnTic6);
            this.panel3.Controls.Add(this.btnTic3);
            this.panel3.Controls.Add(this.btnTic8);
            this.panel3.Controls.Add(this.btnTic5);
            this.panel3.Controls.Add(this.btnTic7);
            this.panel3.Controls.Add(this.btnTic4);
            this.panel3.Controls.Add(this.btnTic2);
            this.panel3.Controls.Add(this.btnTic1);
            this.panel3.Location = new System.Drawing.Point(18, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 522);
            this.panel3.TabIndex = 0;
            // 
            // btnTic9
            // 
            this.btnTic9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic9.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic9.Location = new System.Drawing.Point(491, 348);
            this.btnTic9.Name = "btnTic9";
            this.btnTic9.Size = new System.Drawing.Size(240, 164);
            this.btnTic9.TabIndex = 1;
            this.btnTic9.UseVisualStyleBackColor = false;
            this.btnTic9.Click += new System.EventHandler(this.btnTic9_Click);
            // 
            // btnTic6
            // 
            this.btnTic6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic6.Location = new System.Drawing.Point(491, 178);
            this.btnTic6.Name = "btnTic6";
            this.btnTic6.Size = new System.Drawing.Size(240, 164);
            this.btnTic6.TabIndex = 1;
            this.btnTic6.UseVisualStyleBackColor = false;
            this.btnTic6.Click += new System.EventHandler(this.btnTic6_Click);
            // 
            // btnTic3
            // 
            this.btnTic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic3.Location = new System.Drawing.Point(491, 4);
            this.btnTic3.Name = "btnTic3";
            this.btnTic3.Size = new System.Drawing.Size(240, 164);
            this.btnTic3.TabIndex = 1;
            this.btnTic3.UseVisualStyleBackColor = false;
            this.btnTic3.Click += new System.EventHandler(this.btnTic3_Click);
            // 
            // btnTic8
            // 
            this.btnTic8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic8.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic8.Location = new System.Drawing.Point(247, 348);
            this.btnTic8.Name = "btnTic8";
            this.btnTic8.Size = new System.Drawing.Size(240, 164);
            this.btnTic8.TabIndex = 0;
            this.btnTic8.UseVisualStyleBackColor = false;
            this.btnTic8.Click += new System.EventHandler(this.btnTic8_Click);
            // 
            // btnTic5
            // 
            this.btnTic5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic5.Location = new System.Drawing.Point(247, 178);
            this.btnTic5.Name = "btnTic5";
            this.btnTic5.Size = new System.Drawing.Size(240, 164);
            this.btnTic5.TabIndex = 0;
            this.btnTic5.UseVisualStyleBackColor = false;
            this.btnTic5.Click += new System.EventHandler(this.btnTic5_Click);
            // 
            // btnTic7
            // 
            this.btnTic7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic7.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic7.Location = new System.Drawing.Point(3, 348);
            this.btnTic7.Name = "btnTic7";
            this.btnTic7.Size = new System.Drawing.Size(240, 164);
            this.btnTic7.TabIndex = 0;
            this.btnTic7.UseVisualStyleBackColor = false;
            this.btnTic7.Click += new System.EventHandler(this.btnTic7_Click);
            // 
            // btnTic4
            // 
            this.btnTic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic4.Location = new System.Drawing.Point(3, 178);
            this.btnTic4.Name = "btnTic4";
            this.btnTic4.Size = new System.Drawing.Size(240, 164);
            this.btnTic4.TabIndex = 0;
            this.btnTic4.UseVisualStyleBackColor = false;
            this.btnTic4.Click += new System.EventHandler(this.btnTic4_Click);
            // 
            // btnTic2
            // 
            this.btnTic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic2.Location = new System.Drawing.Point(247, 4);
            this.btnTic2.Name = "btnTic2";
            this.btnTic2.Size = new System.Drawing.Size(240, 164);
            this.btnTic2.TabIndex = 0;
            this.btnTic2.UseVisualStyleBackColor = false;
            this.btnTic2.Click += new System.EventHandler(this.btnTic2_Click);
            // 
            // btnTic1
            // 
            this.btnTic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTic1.Location = new System.Drawing.Point(3, 4);
            this.btnTic1.Name = "btnTic1";
            this.btnTic1.Size = new System.Drawing.Size(240, 164);
            this.btnTic1.TabIndex = 0;
            this.btnTic1.UseVisualStyleBackColor = false;
            this.btnTic1.Click += new System.EventHandler(this.btnTic1_Click);
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Black;
            this.lblHigh.Location = new System.Drawing.Point(1016, 12);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(282, 73);
            this.lblHigh.TabIndex = 0;
            this.lblHigh.Text = "Player X";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTic1;
        private System.Windows.Forms.Button btnTic2;
        private System.Windows.Forms.Button btnTic3;
        private System.Windows.Forms.Button btnTic9;
        private System.Windows.Forms.Button btnTic6;
        private System.Windows.Forms.Button btnTic8;
        private System.Windows.Forms.Button btnTic5;
        private System.Windows.Forms.Button btnTic7;
        private System.Windows.Forms.Button btnTic4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblHigh;
    }
}

