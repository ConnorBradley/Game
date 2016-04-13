using System.Collections.ObjectModel;
using OpenTK;

namespace Game.SceneGraph1
{
    class Group : IComponent
    {
        private ObservableCollection<GameObject> _gameObjects = new ObservableCollection<GameObject>();

        public ObservableCollection<GameObject> GameObjects
        {
            get { return _gameObjects; }
        }

        public void Update(double time, Matrix4d pose)
        {
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Update(time, pose);
            }
        }

        public void Render(double time, Matrix4d pose)
        {
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Render(time, pose);
            }
        }
    }
}
