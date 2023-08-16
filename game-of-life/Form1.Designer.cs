namespace game_of_life
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            init = new Button();
            start = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            stop = new Button();
            reset = new Button();
            speed = new Button();
            display = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            slow = new Button();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            SuspendLayout();
            // 
            // init
            // 
            init.Location = new Point(818, 12);
            init.Name = "init";
            init.Size = new Size(175, 23);
            init.TabIndex = 1;
            init.Text = "initialise grid with rand values";
            init.UseVisualStyleBackColor = true;
            init.Click += button1_Click;
            // 
            // start
            // 
            start.Location = new Point(818, 149);
            start.Name = "start";
            start.Size = new Size(112, 23);
            start.TabIndex = 2;
            start.Text = "start simulation";
            start.UseVisualStyleBackColor = true;
            start.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // stop
            // 
            stop.Location = new Point(818, 178);
            stop.Name = "stop";
            stop.Size = new Size(112, 23);
            stop.TabIndex = 3;
            stop.Text = "pause simulation";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // reset
            // 
            reset.Location = new Point(818, 41);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 4;
            reset.Text = "reset grid";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // speed
            // 
            speed.Location = new Point(818, 207);
            speed.Name = "speed";
            speed.Size = new Size(75, 23);
            speed.TabIndex = 5;
            speed.Text = "speed up";
            speed.UseVisualStyleBackColor = true;
            speed.Click += speed_Click;
            // 
            // display
            // 
            display.Location = new Point(12, 12);
            display.Name = "display";
            display.Size = new Size(800, 800);
            display.TabIndex = 6;
            display.TabStop = false;
            display.MouseDown += display_MouseDown;
            display.MouseUp += display_MouseUp;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // slow
            // 
            slow.Location = new Point(818, 236);
            slow.Name = "slow";
            slow.Size = new Size(75, 23);
            slow.TabIndex = 7;
            slow.Text = "slow down";
            slow.UseVisualStyleBackColor = true;
            slow.Click += slow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 604);
            Controls.Add(slow);
            Controls.Add(display);
            Controls.Add(speed);
            Controls.Add(reset);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(init);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button init;
        private Button start;
        private System.Windows.Forms.Timer timer1;
        private Button stop;
        private Button reset;
        private Button speed;
        private PictureBox display;
        private System.Windows.Forms.Timer timer2;
        private Button slow;
    }
}