namespace HitBall
{
    partial class Rules
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
            this.RulesOfGame = new System.Windows.Forms.Label();
            this.RulesGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RulesOfGame
            // 
            this.RulesOfGame.AutoSize = true;
            this.RulesOfGame.Font = new System.Drawing.Font("Mauryssel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesOfGame.Location = new System.Drawing.Point(358, 9);
            this.RulesOfGame.Name = "RulesOfGame";
            this.RulesOfGame.Size = new System.Drawing.Size(178, 27);
            this.RulesOfGame.TabIndex = 0;
            this.RulesOfGame.Text = "Правила гри";
            // 
            // RulesGame
            // 
            this.RulesGame.AutoSize = true;
            this.RulesGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesGame.Location = new System.Drawing.Point(27, 54);
            this.RulesGame.Name = "RulesGame";
            this.RulesGame.Size = new System.Drawing.Size(46, 17);
            this.RulesGame.TabIndex = 1;
            this.RulesGame.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mauryssel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Гарної гри!";
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RulesGame);
            this.Controls.Add(this.RulesOfGame);
            this.Name = "Rules";
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.Rules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RulesOfGame;
        private System.Windows.Forms.Label RulesGame;
        private System.Windows.Forms.Label label1;
    }
}