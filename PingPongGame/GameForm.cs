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

        private const int baseSpeed = 2;
        private int gameLevel = 7;

        private GameItem player1;
        private GameItem player2;
        private Ball ball;

        private Random random;

        private int player1Score;
        private int player2Score;

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
