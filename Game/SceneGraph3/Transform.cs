using System.Collections.Generic;
using OpenTK;

namespace Game.SceneGraph3
{
    class Transform
    {
        public Matrix4d Relative
        {
            get; set;
        }

        public List<Transform> Children
        {
            get;
            private set;
        } = new List<Transform>();

        public Transform Parent
        { get; set; }
    }
}
