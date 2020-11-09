namespace AudioPlayer
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Program
    {
        static void Main()
        {
            Player player = new Player();
            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();
        }
    }
}
