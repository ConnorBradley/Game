using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ConsoleApplication1
{
    public class Node:Component
    {
        private ObservableCollection<GameObject> _gameObjects = new ObservableCollection<GameObject>();

        public ObservableCollection<GameObject> GameObjects
        {
            get { return _gameObjects; }
        }

        public override sealed void Update(double time, Matrix4d pose)
        {
            foreach(var gameObject in _gameObjects)
            {
                gameObject.Update(time, pose);
            }
        }

        public override sealed void Render(double time, Matrix4d pose)
        {
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Render(time, pose);
            }
        }
    }
}
