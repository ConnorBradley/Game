using OpenTK;

namespace ConsoleApplication1
{
    public abstract class Component
    {
        public void Update(double time)
        {
            Update(time, Matrix4d.Identity);
        }

        public void Render(double time)
        {
            Render(time, Matrix4d.Identity);
        }

        public abstract void Update(double time, Matrix4d pose);

        public abstract void Render(double time, Matrix4d pose);
    }
}
