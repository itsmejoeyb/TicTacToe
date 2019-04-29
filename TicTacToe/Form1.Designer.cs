namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x0y0 = new System.Windows.Forms.Button();
            this.x1y0 = new System.Windows.Forms.Button();
            this.x2y0 = new System.Windows.Forms.Button();
            this.x0y1 = new System.Windows.Forms.Button();
            this.x1y1 = new System.Windows.Forms.Button();
            this.x2y1 = new System.Windows.Forms.Button();
            this.x0y2 = new System.Windows.Forms.Button();
            this.x1y2 = new System.Windows.Forms.Button();
            this.x2y2 = new System.Windows.Forms.Button();
            this.MiniMax = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // x0y0
            // 
            this.x0y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0y0.Location = new System.Drawing.Point(46, 108);
            this.x0y0.Name = "x0y0";
            this.x0y0.Size = new System.Drawing.Size(150, 150);
            this.x0y0.TabIndex = 0;
            this.x0y0.UseVisualStyleBackColor = true;
            this.x0y0.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x1y0
            // 
            this.x1y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1y0.Location = new System.Drawing.Point(202, 108);
            this.x1y0.Name = "x1y0";
            this.x1y0.Size = new System.Drawing.Size(150, 150);
            this.x1y0.TabIndex = 1;
            this.x1y0.UseVisualStyleBackColor = true;
            this.x1y0.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x2y0
            // 
            this.x2y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2y0.Location = new System.Drawing.Point(358, 108);
            this.x2y0.Name = "x2y0";
            this.x2y0.Size = new System.Drawing.Size(150, 150);
            this.x2y0.TabIndex = 2;
            this.x2y0.UseVisualStyleBackColor = true;
            this.x2y0.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x0y1
            // 
            this.x0y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0y1.Location = new System.Drawing.Point(46, 264);
            this.x0y1.Name = "x0y1";
            this.x0y1.Size = new System.Drawing.Size(150, 150);
            this.x0y1.TabIndex = 3;
            this.x0y1.UseVisualStyleBackColor = true;
            this.x0y1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x1y1
            // 
            this.x1y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1y1.Location = new System.Drawing.Point(202, 264);
            this.x1y1.Name = "x1y1";
            this.x1y1.Size = new System.Drawing.Size(150, 150);
            this.x1y1.TabIndex = 4;
            this.x1y1.UseVisualStyleBackColor = true;
            this.x1y1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x2y1
            // 
            this.x2y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2y1.Location = new System.Drawing.Point(358, 264);
            this.x2y1.Name = "x2y1";
            this.x2y1.Size = new System.Drawing.Size(150, 150);
            this.x2y1.TabIndex = 5;
            this.x2y1.UseVisualStyleBackColor = true;
            this.x2y1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x0y2
            // 
            this.x0y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0y2.Location = new System.Drawing.Point(46, 420);
            this.x0y2.Name = "x0y2";
            this.x0y2.Size = new System.Drawing.Size(150, 150);
            this.x0y2.TabIndex = 6;
            this.x0y2.UseVisualStyleBackColor = true;
            this.x0y2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x1y2
            // 
            this.x1y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1y2.Location = new System.Drawing.Point(202, 420);
            this.x1y2.Name = "x1y2";
            this.x1y2.Size = new System.Drawing.Size(150, 150);
            this.x1y2.TabIndex = 7;
            this.x1y2.UseVisualStyleBackColor = true;
            this.x1y2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // x2y2
            // 
            this.x2y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2y2.Location = new System.Drawing.Point(358, 420);
            this.x2y2.Name = "x2y2";
            this.x2y2.Size = new System.Drawing.Size(150, 150);
            this.x2y2.TabIndex = 8;
            this.x2y2.UseVisualStyleBackColor = true;
            this.x2y2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MiniMax
            // 
            this.MiniMax.AutoSize = true;
            this.MiniMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniMax.Location = new System.Drawing.Point(194, 39);
            this.MiniMax.Name = "MiniMax";
            this.MiniMax.Size = new System.Drawing.Size(202, 55);
            this.MiniMax.TabIndex = 9;
            this.MiniMax.Text = "MiniMax";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 32);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 29);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 599);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MiniMax);
            this.Controls.Add(this.x2y2);
            this.Controls.Add(this.x1y2);
            this.Controls.Add(this.x0y2);
            this.Controls.Add(this.x2y1);
            this.Controls.Add(this.x1y1);
            this.Controls.Add(this.x0y1);
            this.Controls.Add(this.x2y0);
            this.Controls.Add(this.x1y0);
            this.Controls.Add(this.x0y0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button x0y0;
        private System.Windows.Forms.Button x1y0;
        private System.Windows.Forms.Button x2y0;
        private System.Windows.Forms.Button x0y1;
        private System.Windows.Forms.Button x1y1;
        private System.Windows.Forms.Button x2y1;
        private System.Windows.Forms.Button x0y2;
        private System.Windows.Forms.Button x1y2;
        private System.Windows.Forms.Button x2y2;
        private System.Windows.Forms.Label MiniMax;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

