using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame.models
{
    /// <summary>
    /// GameComponent manages position, velocity and image of a playable item
    /// </summary>
    public class GameComponent
    {
        public Point Position { get; set; }
        public Point Velocity { get; set; }
        public PictureBox PictureBox { get; set; }

        /// <summary>
        /// Origin of component on screen
        /// </summary>
        public Point Origin => new Point(x: PictureBox.Width / 2, y: PictureBox.Height / 2);
        
        /// <summary>
        /// Upper Left Corner of component
        /// </summary>
        public Point UpperLeftCorner => new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);

        /// <summary>
        /// Upper Right Corner of component
        /// </summary>
        public Point UpperRightCorner => new Point(x: Position.X + Origin.X, y: Position.Y - Origin.Y);

        /// <summary>
        /// Bottom Left Corner of component
        /// </summary>
        public Point BottomLeftComponent => new Point(x: Position.X - Origin.X, y: Position.Y + Origin.Y);

        /// <summary>
        /// Bottom Right Corner of component
        /// </summary>
        public Point BottomRightComponent => new Point(x: Position.X + Origin.X, y: Position.Y + Origin.Y);
        
        /// <summary>
        /// Draw the component on screen with updated values
        /// </summary>
        public void Draw()
        {
            PictureBox.Location = new Point(x: Position.X - Origin.X, y: Position.Y - Origin.Y);
        }
    }
}
