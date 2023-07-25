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
            this.player1Picture = new System.Windows.Forms.PictureBox();
            this.player2Picture = new System.Windows.Forms.PictureBox();
            this.ballPicture = new System.Windows.Forms.PictureBox();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Picture
            // 
            this.player1Picture.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1Picture.Location = new System.Drawing.Point(9, 108);
            this.player1Picture.Margin = new System.Windows.Forms.Padding(2);
            this.player1Picture.Name = "player1Picture";
            this.player1Picture.Size = new System.Drawing.Size(17, 110);
            this.player1Picture.TabIndex = 0;
            this.player1Picture.TabStop = false;
            // 
            // player2Picture
            // 
            this.player2Picture.BackColor = System.Drawing.Color.Red;
            this.player2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2Picture.Location = new System.Drawing.Point(606, 162);
            this.player2Picture.Margin = new System.Windows.Forms.Padding(2);
            this.player2Picture.Name = "player2Picture";
            this.player2Picture.Size = new System.Drawing.Size(17, 110);
            this.player2Picture.TabIndex = 1;
            this.player2Picture.TabStop = false;
            // 
            // ballPicture
            // 
            this.ballPicture.BackColor = System.Drawing.Color.Transparent;
            this.ballPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballPicture.BackgroundImage")));
            this.ballPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballPicture.Location = new System.Drawing.Point(294, 166);
            this.ballPicture.Margin = new System.Windows.Forms.Padding(0);
            this.ballPicture.Name = "ballPicture";
            this.ballPicture.Size = new System.Drawing.Size(48, 52);
            this.ballPicture.TabIndex = 2;
            this.ballPicture.TabStop = false;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.player2ScoreLabel.Location = new System.Drawing.Point(333, 32);
            this.player2ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(36, 19);
            this.player2ScoreLabel.TabIndex = 3;
            this.player2ScoreLabel.Text = "000";
            this.player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.player1ScoreLabel.Location = new System.Drawing.Point(268, 32);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(36, 19);
            this.player1ScoreLabel.TabIndex = 5;
            this.player1ScoreLabel.Text = "000";
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(226, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
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
            this.label1.Location = new System.Drawing.Point(333, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player: 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 16;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // DrawTimer
            // 
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 16;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.ballPicture);
            this.Controls.Add(this.player2Picture);
            this.Controls.Add(this.player1Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "SSS";
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1Picture;
        private System.Windows.Forms.PictureBox player2Picture;
        private System.Windows.Forms.PictureBox ballPicture;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer DrawTimer;
    }
}

