using OpenTK;

namespace ConsoleApplication1.Engine2
{
    interface IComponent
    {
        void Update(double time, Matrix4d pose);

        void Render(double time, Matrix4d pose);
    }
}
