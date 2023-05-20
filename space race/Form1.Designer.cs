namespace space_race
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
            this.p1scorelabel = new System.Windows.Forms.Label();
            this.p2scorelabel = new System.Windows.Forms.Label();
            this.countdownlabel = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1scorelabel
            // 
            this.p1scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1scorelabel.Location = new System.Drawing.Point(437, 467);
            this.p1scorelabel.Name = "p1scorelabel";
            this.p1scorelabel.Size = new System.Drawing.Size(70, 77);
            this.p1scorelabel.TabIndex = 0;
            this.p1scorelabel.Text = "0";
            this.p1scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2scorelabel
            // 
            this.p2scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2scorelabel.Location = new System.Drawing.Point(686, 467);
            this.p2scorelabel.Name = "p2scorelabel";
            this.p2scorelabel.Size = new System.Drawing.Size(70, 77);
            this.p2scorelabel.TabIndex = 1;
            this.p2scorelabel.Text = "0";
            this.p2scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownlabel
            // 
            this.countdownlabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlabel.Location = new System.Drawing.Point(446, 118);
            this.countdownlabel.Name = "countdownlabel";
            this.countdownlabel.Size = new System.Drawing.Size(292, 235);
            this.countdownlabel.TabIndex = 2;
            this.countdownlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerlabel
            // 
            this.timerlabel.BackColor = System.Drawing.Color.Transparent;
            this.timerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.Location = new System.Drawing.Point(529, 9);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(134, 38);
            this.timerlabel.TabIndex = 3;
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputlabel
            // 
            this.outputlabel.BackColor = System.Drawing.Color.Transparent;
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.Location = new System.Drawing.Point(108, 118);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(996, 235);
            this.outputlabel.TabIndex = 4;
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gametimer
            // 
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.countdownlabel);
            this.Controls.Add(this.p2scorelabel);
            this.Controls.Add(this.p1scorelabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "space dodge";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1scorelabel;
        private System.Windows.Forms.Label p2scorelabel;
        private System.Windows.Forms.Label countdownlabel;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Timer Gametimer;
    }
}

