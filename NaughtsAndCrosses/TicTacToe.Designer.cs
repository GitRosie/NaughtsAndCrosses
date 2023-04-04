namespace NaughtsAndCrosses
{
    partial class Form_TicTacToe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Player = new System.Windows.Forms.Label();
            this.Btn_Player = new System.Windows.Forms.Button();
            this.Btn_Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_Player
            // 
            this.Lbl_Player.AutoSize = true;
            this.Lbl_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Player.Location = new System.Drawing.Point(475, 28);
            this.Lbl_Player.Name = "Lbl_Player";
            this.Lbl_Player.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Player.TabIndex = 1;
            this.Lbl_Player.Text = "Player";
            // 
            // Btn_Player
            // 
            this.Btn_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Player.Location = new System.Drawing.Point(479, 64);
            this.Btn_Player.Name = "Btn_Player";
            this.Btn_Player.Size = new System.Drawing.Size(109, 106);
            this.Btn_Player.TabIndex = 2;
            this.Btn_Player.Text = "X";
            this.Btn_Player.UseVisualStyleBackColor = true;
            // 
            // Btn_Restart
            // 
            this.Btn_Restart.Location = new System.Drawing.Point(479, 448);
            this.Btn_Restart.Name = "Btn_Restart";
            this.Btn_Restart.Size = new System.Drawing.Size(108, 27);
            this.Btn_Restart.TabIndex = 3;
            this.Btn_Restart.Text = "Restart";
            this.Btn_Restart.UseVisualStyleBackColor = true;
            this.Btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // Form_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 498);
            this.Controls.Add(this.Btn_Restart);
            this.Controls.Add(this.Btn_Player);
            this.Controls.Add(this.Lbl_Player);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Player;
        private System.Windows.Forms.Button Btn_Player;
        private System.Windows.Forms.Button Btn_Restart;
    }
}

