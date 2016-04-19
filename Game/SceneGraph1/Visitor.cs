namespace Game.SceneGraph1
{
    abstract class Visitor
    {
        public abstract void BeginVisit(Group group);

        public abstract void EndVisit(Group group);

        public abstract void Visit(Component component);

        public abstract void BeginVisit(GameObject gameObject);

        public abstract void EndVisit(GameObject gameObject);
    }
}
