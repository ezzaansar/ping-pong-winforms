using PingPongGame.models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace PingPongGame
{
    public partial class GameForm : Form
    {
        private const int screenWidth = 860;
        private const int screenHeight = 540;

        private const int baseSpeed = 2;
        private int gameLevel = 7;

        private GameComponent player1;
        private GameComponent player2;

        private BallComponent ball;

        private Random random = new Random();

        private int player1Score = 0;
        private int player2Score = 0;

        private int currentY;
        private int currentBallX;

        public GameForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(screenWidth, screenHeight);
            
            InitializeGameComponents();
            ResetBall();
        }

        private void InitializeGameComponents()
        {
            player1 = new GameComponent
            {
                PictureBox = player1Picture
            };

            player2 = new GameComponent {
                PictureBox = player2Picture,
                Position = new Point(screenWidth - 30, screenHeight / 2)
            };

            ball = new BallComponent {
                Velocity = new Point(2, 5),
                PictureBox = ballPicture
            };
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateScene();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            DrawScene();
        }

        private void UpdateScene()
        {
            UpdatePlayer();
            ball.Update();

            CheckWallCollision();
            CheckWallOut();
            CheckPaddleCollision();
        }

        private void DrawScene()
        {
            player1.Draw();
            player2.Draw();
            ball.Draw();
        }

        private void UpdatePlayer()
        {
            int playerX = 0 + 30;
            int playerY = PointToClient(MousePosition).Y;
            player1.Position = new Point(playerX, playerY);

            if (player1.PictureBox.Bottom >= screenHeight)
            {
                player1.Position = new Point(playerX, screenHeight - player1.Origin.Y - 1);
            }
            else if (player1.PictureBox.Top <= 0)
            {
                player1.Position = new Point(playerX, player1.Origin.Y + 1);
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                if (player2.PictureBox.Bottom >= screenHeight)
                {
                    currentY -= 0;
                }
                else
                {
                    currentY += 30;
                }
                player2.Position = new Point(screenWidth - 30, currentY);
            }
            else if (Keyboard.IsKeyDown(Key.W))
            {
                if (player2.PictureBox.Top <= 0)
                {
                    currentY += 0;
                }
                else
                {
                    currentY -= 30;
                }

                int player2X = screenWidth - 30;
                int player2Y = currentY;
                player2.Position = new Point(player2X, player2Y);

            }
        }

        private void ResetBall()
        {
            gameLevel = 7;
            int velocityY = GenerateBallY();
            int velocityX = GenerateBallX();


            ball.Position = new Point(screenWidth / 2, screenHeight / 2);
            ball.Velocity = new Point(velocityX, velocityY);

            currentBallX = velocityX;
        }

        private int GenerateBallX()
        {
            gameLevel += 1;
            int velocityX = gameLevel;
            if (random.Next(2) == 0)
            {
                velocityX *= -1;
            }
            return velocityX;
        }

        private int GenerateBallY()
        {
            gameLevel += (int).5;
            int velocityY = random.Next(0, gameLevel);
            if (random.Next(2) == 0)
            {
                velocityY *= -1;
            }
            return velocityY;
        }

        private void CheckWallCollision()
        {
            if (ballPicture.Bottom >= screenHeight)
            {
                ball.Velocity = new Point(currentBallX, -baseSpeed);
            }
            else if (ballPicture.Top <= 0)
            {
                ball.Velocity = new Point(currentBallX, baseSpeed);
            }
        }

        private void CheckWallOut()
        {
            if (ballPicture.Left < 0)
            {                                      
                ResetBall();
                player2Score += 1;
                player2ScoreLabel.Text = player2Score.ToString();
            }
            else if (ballPicture.Right > screenWidth)
            {
                ResetBall();
                player1Score += 1;
                player1ScoreLabel.Text = player1Score.ToString();
            }
        }

        private void CheckPaddleCollision()
        {
            if (ball.UpperLeftCorner.X < player1.UpperRightCorner.X &&
                ball.BottomLeftCorner.Y > player1.UpperRightCorner.Y &&
                ball.UpperLeftCorner.Y < player1.BottomRightCorner.Y)
            {
                currentBallX = GenerateBallX();
                if (currentBallX < 0)
                {
                    currentBallX *= -1;
                }
                ball.Velocity = new Point(currentBallX, GenerateBallY());
            }

            if (ball.UpperRightCorner.X > player2.UpperLeftCorner.X &&
                ball.BottomRightCorner.Y > player2.UpperLeftCorner.Y &&
                ball.UpperRightCorner.Y < player2.BottomLeftCorner.Y)
            {
                currentBallX = GenerateBallX();
                if (currentBallX > 0)
                {
                    currentBallX *= -1;
                }
                ball.Velocity = new Point(currentBallX, GenerateBallY());
            }
        }
    }
}
