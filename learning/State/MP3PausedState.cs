using System;
namespace learning.State
{
    public class MP3PausedState : AudioPlayerState
    {
        public MP3PausedState() { Console.WriteLine("Paused MP3"); }
        public override void PressPlay(AudioPlayer player)
        {
            player.SetState = new MP3PlayingState();
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new RadioState();
        }
    }
}