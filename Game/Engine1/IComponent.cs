using OpenTK;

namespace Game.Engine1
{
    public interface IComponent
    {
        void Update(double time, Matrix4d pose);

        void Render(double time, Matrix4d pose);
    }
}
