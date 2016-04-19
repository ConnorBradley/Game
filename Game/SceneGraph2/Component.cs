namespace Game.SceneGraph2
{
    abstract class Component
    {
        protected internal abstract void Accept(Visitor visitor);
    }
}
