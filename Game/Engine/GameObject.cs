using System.Collections.ObjectModel;
using System.Diagnostics;
using OpenTK;

namespace ConsoleApplication1
{
    public class GameObject
    {
        private ObservableCollection<Component> _components = new ObservableCollection<Component>();

        public GameObject(params Component[] components)
        {
            Debug.Assert(components != null);

            foreach (var component in components)
            {
                _components.Add(component);
            }
        }

        public ObservableCollection<Component> Components
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
