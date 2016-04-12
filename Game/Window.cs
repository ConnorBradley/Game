using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace Game
{
    /// <summary>
    /// Represents a window.
    /// </summary>
    public sealed class Window : GameWindow
    {
        //private Game _game;

        /// <summary>
        /// Creates and initializes a new instance of the <see cref="Window"/> class.
        /// </summary>
        /// <param name="game">An instance of the <see cref="Game"/> class.</param>
        public Window()
        {
            //Debug.Assert(game != null);

            //_game = game;
        }

        /// <summary>
        /// Occurs when an update is possible.
        /// </summary>
        /// <param name="e">Arguments of a frame, with the time spent since the last update.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            //_game.Update(e.Time);
        }

        /// <summary>
        /// Occurs when an render is possible.
        /// </summary>
        /// <param name="e">Arguments of a frame, with the time spent since the last render.</param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            MakeCurrent();

            GL.Viewport(0, 0, Width, Height);

            base.OnRenderFrame(e);

            //_game.Render(e.Time);

            SwapBuffers();
        }
    }
}
