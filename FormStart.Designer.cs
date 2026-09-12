namespace Progect_Tic_Tac_Toe_Game
{
    partial class FormStart
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnPharaonic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TIC - TAC - TOE GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(50, 130);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(800, 40);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Choose Your Favorite Theme to Start Playing";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClassic
            // 
            this.btnClassic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnClassic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassic.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClassic.FlatAppearance.BorderSize = 2;
            this.btnClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassic.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassic.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnClassic.Location = new System.Drawing.Point(150, 220);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(600, 90);
            this.btnClassic.TabIndex = 2;
            this.btnClassic.Text = "🎮 Classic Dark Theme";
            this.btnClassic.UseVisualStyleBackColor = false;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            // 
            // btnPharaonic
            // 
            this.btnPharaonic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(30)))));
            this.btnPharaonic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharaonic.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnPharaonic.FlatAppearance.BorderSize = 2;
            this.btnPharaonic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharaonic.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharaonic.ForeColor = System.Drawing.Color.Gold;
            this.btnPharaonic.Location = new System.Drawing.Point(150, 360);
            this.btnPharaonic.Name = "btnPharaonic";
            this.btnPharaonic.Size = new System.Drawing.Size(600, 90);
            this.btnPharaonic.TabIndex = 3;
            this.btnPharaonic.Text = "👑 Pharaonic Egyptian Theme";
            this.btnPharaonic.UseVisualStyleBackColor = false;
            this.btnPharaonic.Click += new System.EventHandler(this.btnPharaonic_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnPharaonic);
            this.Controls.Add(this.btnClassic);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Game - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnPharaonic;
    }
}
