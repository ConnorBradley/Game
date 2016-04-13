using OpenTK;

namespace Game.SceneGraph1
{
    interface IComponent
    {
        void Update(double time, Matrix4d pose);

        void Render(double time, Matrix4d pose);
    }
}
