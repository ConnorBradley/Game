using System.Collections.Generic;
using System.Diagnostics;
using OpenTK;

namespace Game.SceneGraph2
{
    class GameObject
    {
        public List<Component> Components
        {
            get;
        } = new List<Component>();

        public List<GameObject> GameObjects
        {
            get;
        } = new List<GameObject>();

        public Matrix4d Transform
        {
            get;
            set;
        }

        protected internal void Accept(Visitor visitor)
        {
            Debug.Assert(visitor != null);

            visitor.BeginVisit(this);

            foreach (var component in Components)
            {
                component.Accept(visitor);
            }

            foreach (var gameObject in GameObjects)
            {
                gameObject.Accept(visitor);
            }

            visitor.EndVisit(this);
        }
    }
}
