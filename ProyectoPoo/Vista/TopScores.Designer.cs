using System.ComponentModel;

namespace ProyectoPoo
{
    partial class TopScores
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(TopScores));
            this.scores1 = new ProyectoPoo.Scores();
            this.SuspendLayout();
            // 
            // scores1
            // 
            this.scores1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scores1.BackColor = System.Drawing.Color.Black;
            this.scores1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scores1.Location = new System.Drawing.Point(0, 0);
            this.scores1.Name = "scores1";
            this.scores1.Size = new System.Drawing.Size(561, 690);
            this.scores1.TabIndex = 0;
            // 
            // TopScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 690);
            this.Controls.Add(this.scores1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "TopScores";
            this.Text = "TopScores";
            this.ResumeLayout(false);
        }

        #endregion

        private ProyectoPoo.Scores scores1;
    }
}