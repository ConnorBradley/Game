namespace Game.SceneGraph1
{
    abstract class Component
    {
        public virtual void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
