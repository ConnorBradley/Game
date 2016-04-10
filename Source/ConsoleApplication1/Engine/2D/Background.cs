using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace ConsoleApplication1
{
    public class Background: Component
    {
        private Color _color;

        public Background(Color color)
        {
            _color = color;
        }

        public override void Update(double time, Matrix4d pose)
        {
            // Void
        }

        public override void Render(double time, Matrix4d pose)
        {
            GL.ClearColor(_color);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }
    }
}
