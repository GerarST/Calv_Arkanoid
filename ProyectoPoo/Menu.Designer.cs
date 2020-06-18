using System.ComponentModel;

namespace ProyectoPoo
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_TopScores = new System.Windows.Forms.Button();
            this.bttn_Ins = new System.Windows.Forms.Button();
            this.bttn_Play = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bttn_Close, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttn_TopScores, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttn_Ins, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttn_Play, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttn_Close
            // 
            this.bttn_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Close.Location = new System.Drawing.Point(3, 479);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(920, 115);
            this.bttn_Close.TabIndex = 4;
            this.bttn_Close.Text = "SALIR";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_TopScores
            // 
            this.bttn_TopScores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_TopScores.BackColor = System.Drawing.Color.Transparent;
            this.bttn_TopScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_TopScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_TopScores.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_TopScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_TopScores.Location = new System.Drawing.Point(3, 360);
            this.bttn_TopScores.Name = "bttn_TopScores";
            this.bttn_TopScores.Size = new System.Drawing.Size(920, 113);
            this.bttn_TopScores.TabIndex = 3;
            this.bttn_TopScores.Text = "MEJORES PUNTAJES";
            this.bttn_TopScores.UseVisualStyleBackColor = false;
            this.bttn_TopScores.Click += new System.EventHandler(this.bttn_TopScores_Click);
            // 
            // bttn_Ins
            // 
            this.bttn_Ins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_Ins.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Ins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_Ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Ins.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Ins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Ins.Location = new System.Drawing.Point(3, 241);
            this.bttn_Ins.Name = "bttn_Ins";
            this.bttn_Ins.Size = new System.Drawing.Size(920, 113);
            this.bttn_Ins.TabIndex = 2;
            this.bttn_Ins.Text = "INSTRUCCIONES";
            this.bttn_Ins.UseVisualStyleBackColor = false;
            this.bttn_Ins.Click += new System.EventHandler(this.bttn_Ins_Click);
            // 
            // bttn_Play
            // 
            this.bttn_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_Play.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Play.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Play.Location = new System.Drawing.Point(3, 122);
            this.bttn_Play.Name = "bttn_Play";
            this.bttn_Play.Size = new System.Drawing.Size(920, 113);
            this.bttn_Play.TabIndex = 1;
            this.bttn_Play.Text = "JUGAR";
            this.bttn_Play.UseVisualStyleBackColor = false;
            this.bttn_Play.Click += new System.EventHandler(this.bttn_Play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(926, 597);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Ins;
        private System.Windows.Forms.Button bttn_Play;
        private System.Windows.Forms.Button bttn_TopScores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}