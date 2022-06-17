using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.State
{
    public class StandbyState : AudioPlayerState // készenléti állapot
    {
        public StandbyState() { Console.WriteLine("StandBy"); }
        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Play pressed: no effect");
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new MP3PlayingState();
        }
    }
}
