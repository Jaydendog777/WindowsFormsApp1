namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1Points = new System.Windows.Forms.Label();
            this.p2Points = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1Points
            // 
            this.p1Points.BackColor = System.Drawing.Color.Transparent;
            this.p1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Points.ForeColor = System.Drawing.Color.DodgerBlue;
            this.p1Points.Location = new System.Drawing.Point(12, 386);
            this.p1Points.Name = "p1Points";
            this.p1Points.Size = new System.Drawing.Size(61, 54);
            this.p1Points.TabIndex = 0;
            this.p1Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Points
            // 
            this.p2Points.BackColor = System.Drawing.Color.Transparent;
            this.p2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Points.ForeColor = System.Drawing.Color.LawnGreen;
            this.p2Points.Location = new System.Drawing.Point(923, 386);
            this.p2Points.Name = "p2Points";
            this.p2Points.Size = new System.Drawing.Size(61, 54);
            this.p2Points.TabIndex = 1;
            this.p2Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(365, 40);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(280, 54);
            this.winLabel.TabIndex = 2;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 449);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p2Points);
            this.Controls.Add(this.p1Points);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1Points;
        private System.Windows.Forms.Label p2Points;
        private System.Windows.Forms.Label winLabel;
    }
}

