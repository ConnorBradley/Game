using System.Collections.Generic;

namespace Game.SceneGraph3
{
    class GameObject
    {
        public Transform Transform
        {
            get; set;
        } = new Transform();

        public List<IComponent> Components
        {
            get;
            private set;
        } = new List<IComponent>();

        public void Update(double time)
        {
            foreach (var component in Components)
            {
                component.Update(time, Transform);
            }

            foreach (var gameObject in Transform.Children)
            {
                // TODO: Weird...
            }
        }
    }
}
