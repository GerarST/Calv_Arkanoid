using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProyectoPoo
{
    partial class ControlArkanoid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ControlArkanoid));
            this.platform = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.Image = ((System.Drawing.Image) (resources.GetObject("platform.Image")));
            this.platform.InitialImage = ((System.Drawing.Image) (resources.GetObject("platform.InitialImage")));
            this.platform.Location = new System.Drawing.Point(628, 647);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(180, 59);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.platformTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.BallTimer_Tick_1);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image) (resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(694, 616);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(52, 46);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // ControlArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ball);
            this.Controls.Add(this.platform);
            this.DoubleBuffered = true;
            this.Name = "ControlArkanoid";
            this.Size = new System.Drawing.Size(1420, 758);
            this.Load += new System.EventHandler(this.ControlArkanoid_Load);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(PlatformBall_PreviewKeyDown);
            this.KeyDown += new KeyEventHandler(Game_KeyDown);
        }

        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer timer2;
    }
}