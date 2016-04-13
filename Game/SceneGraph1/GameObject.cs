using System.Collections.ObjectModel;
using OpenTK;

namespace Game.SceneGraph1
{
    class GameObject
    {
        public ObservableCollection<IComponent> Components
        {
            get;
            private set;
        }

        public Matrix4d Transform
        {
            get;
            set;
        } = Matrix4d.Identity;

        public void Update(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in Components)
            {
                component.Update(time, pose);
            }
        }

        public void Render(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in Components)
            {
                component.Render(time, pose);
            }
        }
    }
}
