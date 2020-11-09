using System;
using System.Collections.Generic;
using System.Text;

namespace AudioPlayer
{
    public class Player: IPlayable, IRecodable

    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Pause()
        {
            Console.WriteLine("Pause melody");
        }

        public void Stop()
        {
            Console.WriteLine("Stop melody");
        }

        public void Record()
        {
            Console.WriteLine("Record melody");
        }
    }
}
