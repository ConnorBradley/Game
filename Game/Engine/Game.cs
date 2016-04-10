using System.Collections.ObjectModel;
using System.Drawing;
using OpenTK.Graphics.OpenGL4;

namespace ConsoleApplication1
{
    public class Game : Node
    {
        public Game()
        {
            GameObjects.Add(new GameObject(new Background(Color.Blue)));
        }
    }
}
