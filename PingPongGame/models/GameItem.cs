using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame.models
{
    /// <summary>
    /// GameItem manages speed, position and image of a playable item
    /// </summary>
    public class GameItem
    {
        public Point Position { get; set; }
        public Point Speed { get; set; }
        public PictureBox PictureBox { get; set; }

        public Point Origin => new Point(x: PictureBox.Width / 2, y: PictureBox.Height / 2);
        
        public Point LeftUpCorner => new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);

        public Point RightUpCorner => new Point(x: Position.X + Origin.X, y: Position.Y - Origin.Y);
        
        public Point LeftBottomCorner => new Point(x: Position.X - Origin.X, y: Position.Y + Origin.Y);

        public Point RightBottomCorner => new Point(x: Position.X + Origin.X, y: Position.Y + Origin.Y);
        
        public void Draw()
        {
            PictureBox.Location = new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);
        }
    }
}
