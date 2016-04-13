using System.Collections.ObjectModel;
using OpenTK;

namespace Game.SceneGraph1
{
    class Group : IComponent
    {
        public ObservableCollection<GameObject> GameObjects
        {
            get;
            private set;
        } = new ObservableCollection<GameObject>();

        public void Update(double time, Matrix4d pose)
        {
            foreach (var gameObject in GameObjects)
            {
                gameObject.Update(time, pose);
            }
        }

        public void Render(double time, Matrix4d pose)
        {
            foreach (var gameObject in GameObjects)
            {
                gameObject.Render(time, pose);
            }
        }
    }
}
