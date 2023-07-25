using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame.models
{
    /// <summary>
    /// GameItem manages position, velocity and image of a playable item
    /// </summary>
    public class GameComponent
    {
        public Point Position { get; set; }
        public Point Velocity { get; set; }
        public PictureBox PictureBox { get; set; }

        public Point Origin => new Point(x: PictureBox.Width / 2, y: PictureBox.Height / 2);
        
        public Point UpperLeftCorner => new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);

        public Point UpperRightCorner => new Point(x: Position.X + Origin.X, y: Position.Y - Origin.Y);
        
        public Point BottomLeftComponent => new Point(x: Position.X - Origin.X, y: Position.Y + Origin.Y);

        public Point BottomRightComponent => new Point(x: Position.X + Origin.X, y: Position.Y + Origin.Y);
        
        public void Draw()
        {
            PictureBox.Location = new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);
        }
    }
}
