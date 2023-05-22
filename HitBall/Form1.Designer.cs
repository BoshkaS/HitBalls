namespace HitBall
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartMain = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.Top10 = new System.Windows.Forms.Button();
            this.AllPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartMain
            // 
            this.StartMain.Location = new System.Drawing.Point(752, 96);
            this.StartMain.Name = "StartMain";
            this.StartMain.Size = new System.Drawing.Size(140, 39);
            this.StartMain.TabIndex = 0;
            this.StartMain.Text = "Розпочати гру";
            this.StartMain.UseVisualStyleBackColor = true;
            this.StartMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rules
            // 
            this.Rules.Location = new System.Drawing.Point(752, 32);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(140, 39);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Правила гри";
            this.Rules.UseVisualStyleBackColor = true;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Top10
            // 
            this.Top10.Location = new System.Drawing.Point(752, 159);
            this.Top10.Name = "Top10";
            this.Top10.Size = new System.Drawing.Size(140, 39);
            this.Top10.TabIndex = 3;
            this.Top10.Text = "Топ 10 гравців";
            this.Top10.UseVisualStyleBackColor = true;
            this.Top10.Click += new System.EventHandler(this.Top10_Click);
            // 
            // AllPlayers
            // 
            this.AllPlayers.Location = new System.Drawing.Point(752, 225);
            this.AllPlayers.Name = "AllPlayers";
            this.AllPlayers.Size = new System.Drawing.Size(140, 39);
            this.AllPlayers.TabIndex = 4;
            this.AllPlayers.Text = "Усі гравці";
            this.AllPlayers.UseVisualStyleBackColor = true;
            this.AllPlayers.Click += new System.EventHandler(this.AllPlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.AllPlayers);
            this.Controls.Add(this.Top10);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.StartMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button StartMain;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Button Top10;
        private System.Windows.Forms.Button AllPlayers;
    }
}

