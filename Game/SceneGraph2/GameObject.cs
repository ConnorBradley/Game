using System.Collections.Generic;
using OpenTK;

namespace Game.SceneGraph2
{
    class GameObject
    {
        public List<IComponent> Components
        {
            get;
            private set;
        } = new List<IComponent>();

        public List<GameObject> GameObjects
        {
            get;
            private set;
        } = new List<GameObject>();

        public Matrix4d Transform
        {
            get;
            set;
        }

        public void Update(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in Components)
            {
                component.Update(time, pose);
            }

            foreach (var gameObject in GameObjects)
            {
                gameObject.Update(time, pose);
            }
        }

        public void Render(double time, Matrix4d pose)
        {
            pose = pose * Transform;

            foreach (var component in Components)
            {
                component.Render(time, pose);
            }

            foreach (var gameObject in GameObjects)
            {
                gameObject.Render(time, pose);
            }
        }
    }
}
