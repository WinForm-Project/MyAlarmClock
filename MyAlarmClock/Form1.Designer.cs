namespace MyAlarmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hnum = new System.Windows.Forms.NumericUpDown();
            this.mnum = new System.Windows.Forms.NumericUpDown();
            this.snum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.CoutTimer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.hnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // hnum
            // 
            this.hnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hnum.Location = new System.Drawing.Point(323, 161);
            this.hnum.Margin = new System.Windows.Forms.Padding(4);
            this.hnum.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hnum.Name = "hnum";
            this.hnum.Size = new System.Drawing.Size(65, 38);
            this.hnum.TabIndex = 0;
            // 
            // mnum
            // 
            this.mnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mnum.Location = new System.Drawing.Point(429, 161);
            this.mnum.Margin = new System.Windows.Forms.Padding(4);
            this.mnum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mnum.Name = "mnum";
            this.mnum.Size = new System.Drawing.Size(69, 38);
            this.mnum.TabIndex = 1;
            this.mnum.ValueChanged += new System.EventHandler(this.minutes_ValueChanged);
            // 
            // snum
            // 
            this.snum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snum.Location = new System.Drawing.Point(540, 161);
            this.snum.Margin = new System.Windows.Forms.Padding(4);
            this.snum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(71, 38);
            this.snum.TabIndex = 2;
            this.snum.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(396, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(507, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(401, 241);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 28);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(465, 241);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 28);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Visible = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(357, 241);
            this.Finish.Margin = new System.Windows.Forms.Padding(4);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(100, 28);
            this.Finish.TabIndex = 7;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Visible = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(465, 241);
            this.Continue.Margin = new System.Windows.Forms.Padding(4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(100, 28);
            this.Continue.TabIndex = 8;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // CoutTimer
            // 
            this.CoutTimer.AutoSize = true;
            this.CoutTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoutTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoutTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoutTimer.Location = new System.Drawing.Point(424, 171);
            this.CoutTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoutTimer.Name = "CoutTimer";
            this.CoutTimer.Size = new System.Drawing.Size(0, 25);
            this.CoutTimer.TabIndex = 9;
            this.CoutTimer.Click += new System.EventHandler(this.CoutTimer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.DimGray;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(455, 357);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(75, 23);
            this.Player.TabIndex = 10;
            this.Player.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.CoutTimer);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snum);
            this.Controls.Add(this.mnum);
            this.Controls.Add(this.hnum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hnum;
        private System.Windows.Forms.NumericUpDown mnum;
        private System.Windows.Forms.NumericUpDown snum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label CoutTimer;
        private System.Windows.Forms.ImageList imageList1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
    }
}

