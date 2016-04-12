using System.Collections.ObjectModel;
using System.Diagnostics;
using OpenTK;

namespace Game.Engine1
{
    public class GameObject
    {
        private ObservableCollection<IComponent> _components = new ObservableCollection<IComponent>();

        public GameObject(params IComponent[] components)
        {
            Debug.Assert(components != null);

            foreach (var component in components)
            {
                _components.Add(component);
            }
        }

        public ObservableCollection<IComponent> Components
        {
            get { return _components; }
        }

        public Matrix4d Transform
        {
            get;
            set;
        } = Matrix4d.Identity;

        public void Update(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in _components)
            {
                component.Update(time, pose);
            }
        }

        public void Render(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in _components)
            {
                component.Render(time, pose);
            }
        }
    }
}
