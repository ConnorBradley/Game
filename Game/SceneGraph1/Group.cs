using System.Collections.ObjectModel;

namespace Game.SceneGraph1
{
    class Group : Component
    {
        public ObservableCollection<GameObject> GameObjects
        {
            get;
            private set;
        } = new ObservableCollection<GameObject>();

        public override void Accept(Visitor visitor)
        {
            visitor.BeginVisit(this);

            foreach (var gameObject in GameObjects)
            {
                gameObject.Accept(visitor);
            }

            visitor.EndVisit(this);
        }
    }
}
