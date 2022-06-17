using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace learning.State
{
    public class MP3PlayingState : AudioPlayerState
    {
        public MP3PlayingState() { Console.WriteLine("Playing MP3"); }
        public override void PressPlay(AudioPlayer player)
        {
            player.SetState = new MP3PausedState();
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new RadioState();
        }
    }
}