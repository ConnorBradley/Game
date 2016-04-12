using System.Collections.Generic;
using OpenTK;

namespace ConsoleApplication1.Engine2
{
    class GameObject
    {
        private List<IComponent> _components = new List<IComponent>();
        private List<GameObject> _gameObjects = new List<GameObject>();
        public List<IComponent> Components
        {
            get { return _components; }
        }

        public List<GameObject> GameObjects
        {
            get { return _gameObjects; }
        }

        public Matrix4d Transform
        {
            get;
            set;
        }

        public void Update(double time)
        {
            Update(time, Matrix4d.Identity);
        }

        public void Update(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in _components)
            {
                component.Update(time, pose);
            }

            foreach (var gameObject in _gameObjects)
            {
                gameObject.Update(time, pose);
            }
        }

        public void Render(double time)
        {
            Render(time, Matrix4d.Identity);
        }

        public void Render(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in _components)
            {
                component.Render(time, pose);
            }

            foreach (var gameObject in _gameObjects)
            {
                gameObject.Render(time, pose);
            }
        }
    }
}
