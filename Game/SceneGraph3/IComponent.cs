namespace Game.SceneGraph3
{
    interface IComponent
    {
        void Update(double time, Transform transform);

        void Render(double time, Transform transform);
    }
}
