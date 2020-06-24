using System.ComponentModel;

namespace ProyectoPoo
{
    partial class GameOver
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
                new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttn_back = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.lbl_tLives = new System.Windows.Forms.Label();
            this.lbl_tScore = new System.Windows.Forms.Label();
            this.lbl_tFScore = new System.Windows.Forms.Label();
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.lbl_lives = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_final_score = new System.Windows.Forms.Label();
            this.lbl_tExtra = new System.Windows.Forms.Label();
            this.lbl_extra_points = new System.Windows.Forms.Label();
            this.lbl_plus_extra = new System.Windows.Forms.Label();
            this.lbl_bye = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bttn_back, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_player, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tLives, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tScore, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tFScore, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nickname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_lives, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_score, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_final_score, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tExtra, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_extra_points, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plus_extra, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bye, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttn_back
            // 
            this.bttn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_back.BackColor = System.Drawing.Color.Transparent;
            this.bttn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_back.Location = new System.Drawing.Point(3, 675);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(336, 71);
            this.bttn_back.TabIndex = 2;
            this.bttn_back.Text = "VOLVER AL MENU";
            this.bttn_back.UseVisualStyleBackColor = false;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_title, 4);
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1364, 112);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "FIN DEL JUEGO";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_player
            // 
            this.lbl_player.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_player.ForeColor = System.Drawing.Color.White;
            this.lbl_player.Location = new System.Drawing.Point(3, 112);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(336, 112);
            this.lbl_player.TabIndex = 4;
            this.lbl_player.Text = "JUGADOR:";
            this.lbl_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tLives
            // 
            this.lbl_tLives.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tLives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_tLives.ForeColor = System.Drawing.Color.White;
            this.lbl_tLives.Location = new System.Drawing.Point(3, 224);
            this.lbl_tLives.Name = "lbl_tLives";
            this.lbl_tLives.Size = new System.Drawing.Size(336, 112);
            this.lbl_tLives.TabIndex = 5;
            this.lbl_tLives.Text = "VIDAS RESTANTES:";
            this.lbl_tLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tScore
            // 
            this.lbl_tScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_tScore.ForeColor = System.Drawing.Color.White;
            this.lbl_tScore.Location = new System.Drawing.Point(3, 336);
            this.lbl_tScore.Name = "lbl_tScore";
            this.lbl_tScore.Size = new System.Drawing.Size(336, 112);
            this.lbl_tScore.TabIndex = 6;
            this.lbl_tScore.Text = "SCORE:";
            this.lbl_tScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tFScore
            // 
            this.lbl_tFScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tFScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tFScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_tFScore.ForeColor = System.Drawing.Color.White;
            this.lbl_tFScore.Location = new System.Drawing.Point(3, 448);
            this.lbl_tFScore.Name = "lbl_tFScore";
            this.lbl_tFScore.Size = new System.Drawing.Size(336, 112);
            this.lbl_tFScore.TabIndex = 7;
            this.lbl_tFScore.Text = "FINAL SCORE:";
            this.lbl_tFScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_nickname.ForeColor = System.Drawing.Color.White;
            this.lbl_nickname.Location = new System.Drawing.Point(345, 112);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(336, 112);
            this.lbl_nickname.TabIndex = 8;
            this.lbl_nickname.Text = "NOMBREDELJ";
            this.lbl_nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lives
            // 
            this.lbl_lives.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_lives.ForeColor = System.Drawing.Color.White;
            this.lbl_lives.Location = new System.Drawing.Point(345, 224);
            this.lbl_lives.Name = "lbl_lives";
            this.lbl_lives.Size = new System.Drawing.Size(336, 112);
            this.lbl_lives.TabIndex = 9;
            this.lbl_lives.Text = "x0";
            this.lbl_lives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_score
            // 
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(345, 336);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(336, 112);
            this.lbl_score.TabIndex = 10;
            this.lbl_score.Text = "10000";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_final_score
            // 
            this.lbl_final_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_final_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_final_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_final_score.ForeColor = System.Drawing.Color.White;
            this.lbl_final_score.Location = new System.Drawing.Point(345, 448);
            this.lbl_final_score.Name = "lbl_final_score";
            this.lbl_final_score.Size = new System.Drawing.Size(336, 112);
            this.lbl_final_score.TabIndex = 11;
            this.lbl_final_score.Text = "11000";
            this.lbl_final_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tExtra
            // 
            this.lbl_tExtra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_tExtra.ForeColor = System.Drawing.Color.White;
            this.lbl_tExtra.Location = new System.Drawing.Point(687, 224);
            this.lbl_tExtra.Name = "lbl_tExtra";
            this.lbl_tExtra.Size = new System.Drawing.Size(336, 112);
            this.lbl_tExtra.TabIndex = 12;
            this.lbl_tExtra.Text = "x1000";
            this.lbl_tExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_extra_points
            // 
            this.lbl_extra_points.BackColor = System.Drawing.Color.Transparent;
            this.lbl_extra_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_extra_points.ForeColor = System.Drawing.Color.White;
            this.lbl_extra_points.Location = new System.Drawing.Point(1029, 224);
            this.lbl_extra_points.Name = "lbl_extra_points";
            this.lbl_extra_points.Size = new System.Drawing.Size(337, 112);
            this.lbl_extra_points.TabIndex = 13;
            this.lbl_extra_points.Text = "=0000";
            this.lbl_extra_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_plus_extra
            // 
            this.lbl_plus_extra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_plus_extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_plus_extra.ForeColor = System.Drawing.Color.White;
            this.lbl_plus_extra.Location = new System.Drawing.Point(687, 336);
            this.lbl_plus_extra.Name = "lbl_plus_extra";
            this.lbl_plus_extra.Size = new System.Drawing.Size(336, 112);
            this.lbl_plus_extra.TabIndex = 14;
            this.lbl_plus_extra.Text = "+0000";
            this.lbl_plus_extra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_bye
            // 
            this.lbl_bye.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_bye, 4);
            this.lbl_bye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bye.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_bye.ForeColor = System.Drawing.Color.White;
            this.lbl_bye.Location = new System.Drawing.Point(3, 560);
            this.lbl_bye.Name = "lbl_bye";
            this.lbl_bye.Size = new System.Drawing.Size(1364, 112);
            this.lbl_bye.TabIndex = 15;
            this.lbl_bye.Text = "GRACIAS POR JUGAR!";
            this.lbl_bye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GameOver";
            this.Text = "Arkanoid";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_tLives;
        private System.Windows.Forms.Label lbl_tExtra;
        private System.Windows.Forms.Label lbl_final_score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_lives;
        private System.Windows.Forms.Label lbl_tScore;
        private System.Windows.Forms.Label lbl_tFScore;
        private System.Windows.Forms.Label lbl_nickname;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Label lbl_plus_extra;
        private System.Windows.Forms.Label lbl_extra_points;
        private System.Windows.Forms.Label lbl_bye;
    }
}