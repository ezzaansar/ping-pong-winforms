using System.Drawing;

namespace PingPongGame.models
{
    /// <summary>
    /// A class representing Ball component
    /// </summary>
    public class BallComponent : GameComponent
    {
        /// <summary>
        /// Update position of ball on screen
        /// </summary>
        public void Update()
        {
            this.Position = new Point(x: Position.X + Velocity.X, y: Position.Y + Velocity.Y);
        }
    }
}
