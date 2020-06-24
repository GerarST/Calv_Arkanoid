using System.ComponentModel;

namespace ProyectoPoo
{
    partial class PlayerNickname
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
                new System.ComponentModel.ComponentResourceManager(typeof(PlayerNickname));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNickname = new System.Windows.Forms.Label();
            this.bttn_Volver = new System.Windows.Forms.Button();
            this.bttn_Continuar = new System.Windows.Forms.Button();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
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
            this.tableLayoutPanel1.Controls.Add(this.lblNickname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttn_Volver, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttn_Continuar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNickname, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.69942F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.80347F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30443F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNickname
            // 
            this.lblNickname.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNickname, 2);
            this.lblNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNickname.ForeColor = System.Drawing.Color.White;
            this.lblNickname.Location = new System.Drawing.Point(3, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(460, 123);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Nickname:";
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_Volver
            // 
            this.bttn_Volver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.bttn_Volver.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("bttn_Volver.BackgroundImage")));
            this.bttn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Volver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Volver.ForeColor = System.Drawing.Color.White;
            this.bttn_Volver.Location = new System.Drawing.Point(3, 426);
            this.bttn_Volver.Name = "bttn_Volver";
            this.bttn_Volver.Size = new System.Drawing.Size(227, 90);
            this.bttn_Volver.TabIndex = 1;
            this.bttn_Volver.Text = "Volver";
            this.bttn_Volver.UseVisualStyleBackColor = false;
            this.bttn_Volver.Click += new System.EventHandler(this.bttn_Volver_Click);
            // 
            // bttn_Continuar
            // 
            this.bttn_Continuar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_Continuar.BackColor = System.Drawing.Color.DimGray;
            this.bttn_Continuar.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("bttn_Continuar.BackgroundImage")));
            this.bttn_Continuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Continuar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_Continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttn_Continuar.ForeColor = System.Drawing.Color.White;
            this.bttn_Continuar.Location = new System.Drawing.Point(702, 426);
            this.bttn_Continuar.Name = "bttn_Continuar";
            this.bttn_Continuar.Size = new System.Drawing.Size(228, 90);
            this.bttn_Continuar.TabIndex = 2;
            this.bttn_Continuar.Text = "Continuar";
            this.bttn_Continuar.UseVisualStyleBackColor = false;
            this.bttn_Continuar.Click += new System.EventHandler(this.bttn_Continuar_Click);
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNickname.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNickname, 2);
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNickname.ForeColor = System.Drawing.Color.White;
            this.txtNickname.Location = new System.Drawing.Point(470, 51);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(459, 21);
            this.txtNickname.TabIndex = 3;
            // 
            // PlayerNickname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "PlayerNickname";
            this.Text = "Arkanoid";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Button bttn_Continuar;
        private System.Windows.Forms.Button bttn_Volver;
        private System.Windows.Forms.TextBox txtNickname;
    }
}