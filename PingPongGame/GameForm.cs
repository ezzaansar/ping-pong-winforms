using PingPongGame.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class GameForm : Form
    {
        private const int ScreenWidth = 860;
        private const int ScreenHeight = 540;

        private const int baseSpeed = 2;
        private int gameLevel = 7;

        private GameItem player1 = new GameItem();
        private GameItem player2 = new GameItem
        {
            Position = new Point(ScreenWidth - 3, ScreenHeight / 2)
        };

        private Ball ball = new Ball
        {
            Speed = new Point(2, 5)
        };

        private Random random = new Random();

        private int player1Score = 0;
        private int player2Score = 0;

        public GameForm()
        {
            InitializeComponent();
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
