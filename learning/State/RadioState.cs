using System;
namespace learning.State
{
    public class RadioState : AudioPlayerState
    {
        public RadioState() { Console.WriteLine("Playing Radio"); }
        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Switch to next Station");
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new StandbyState();
        }
    }
}