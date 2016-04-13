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
    }
}
