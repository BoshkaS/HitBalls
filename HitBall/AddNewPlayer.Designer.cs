namespace HitBall
{
    partial class AddNewPlayer
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
            this.AddPlayer = new System.Windows.Forms.Label();
            this.NewPlayer = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPlayer
            // 
            this.AddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlayer.AutoSize = true;
            this.AddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPlayer.Location = new System.Drawing.Point(261, 62);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(230, 26);
            this.AddPlayer.TabIndex = 0;
            this.AddPlayer.Text = "Write down your name";
            // 
            // NewPlayer
            // 
            this.NewPlayer.Location = new System.Drawing.Point(221, 143);
            this.NewPlayer.Name = "NewPlayer";
            this.NewPlayer.Size = new System.Drawing.Size(309, 22);
            this.NewPlayer.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(263, 294);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(228, 54);
            this.Start.TabIndex = 2;
            this.Start.Text = "Розпочати";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.NewPlayer);
            this.Controls.Add(this.AddPlayer);
            this.Name = "AddNewPlayer";
            this.Text = "AddNewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPlayer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox NewPlayer;
    }
}