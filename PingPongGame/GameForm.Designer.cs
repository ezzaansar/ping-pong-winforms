namespace PingPongGame
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.aiScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Black;
            this.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1.Location = new System.Drawing.Point(12, 133);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(22, 135);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Red;
            this.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2.Location = new System.Drawing.Point(808, 200);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(22, 135);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Location = new System.Drawing.Point(392, 204);
            this.ball.Margin = new System.Windows.Forms.Padding(0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(64, 64);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.userScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.userScoreLabel.Location = new System.Drawing.Point(444, 40);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(43, 23);
            this.userScoreLabel.TabIndex = 3;
            this.userScoreLabel.Text = "000";
            this.userScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aiScoreLabel
            // 
            this.aiScoreLabel.AutoSize = true;
            this.aiScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiScoreLabel.ForeColor = System.Drawing.Color.DimGray;
            this.aiScoreLabel.Location = new System.Drawing.Point(358, 40);
            this.aiScoreLabel.Name = "aiScoreLabel";
            this.aiScoreLabel.Size = new System.Drawing.Size(43, 23);
            this.aiScoreLabel.TabIndex = 5;
            this.aiScoreLabel.Text = "000";
            this.aiScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(302, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player: 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(444, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player: 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 16;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 16;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aiScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userScoreLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameForm";
            this.Text = "SSS";
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label aiScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer DrawTimer;
    }
}

