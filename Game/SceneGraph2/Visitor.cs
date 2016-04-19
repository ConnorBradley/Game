namespace Game.SceneGraph2
{
    abstract class Visitor
    {
        protected internal abstract void BeginVisit(GameObject gameObject);

        protected internal abstract void EndVisit(GameObject gameObject);

        protected internal abstract void Visit(Component component);
    }
}
