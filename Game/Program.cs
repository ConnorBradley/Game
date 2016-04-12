namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var gameWindow = new Window())
            {
                gameWindow.Run(60);
            }
        }
    }
}
