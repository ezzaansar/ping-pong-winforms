using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGame.models
{
    public class Ball : GameItem
    {
        public void Update()
        {
            this.Position = new Point(x: Position.X + Speed.X, y: Position.Y + Speed.Y);
        }
    }
}
