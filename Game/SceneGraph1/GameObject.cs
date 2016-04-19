using System.Collections.Generic;
using OpenTK;

namespace Game.SceneGraph1
{
    class GameObject
    {
        public List<Component> Components
        {
            get;
        } = new List<Component>();

        public Matrix4d Transform
        {
            get;
            set;
        } = Matrix4d.Identity;

        public void Accept(Visitor visitor)
        {
            visitor.BeginVisit(this);

            foreach (var component in Components)
            {
                component.Accept(visitor);
            }

            visitor.EndVisit(this);
        }
    }
}
