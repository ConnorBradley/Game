using OpenTK.Graphics.OpenGL4;

namespace ConsoleApplication1
{
    /// <summary>
    /// Represents a game with an <see cref="Update(double)"/> method and a <see cref="Render(double)"/> method.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Updates the game.
        /// </summary>
        /// <param name="time">The time spent in seconds since the last call to this <see cref="Update(double)"/> method.</param>
        public void Update(double time)
        {
            // TODO
        }

        /// <summary>
        /// Renders the game.
        /// </summary>
        /// <param name="time">The time spent in seconds since the last call to this <see cref="Render(double)"/> method.</param>
        public void Render(double time)
        {
            // TODO

            GL.ClearColor(System.Drawing.Color.Red);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }
    }
}
