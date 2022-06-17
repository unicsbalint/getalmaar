using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.State
{
    public class AudioPlayer
    {
        private AudioPlayerState state; // ebben tároljuk a belső állapotot
        public AudioPlayer(AudioPlayerState state) { this.state = state; }
        public AudioPlayerState SetState
        {
            get { return state; }
            set { state = value; }
        }
        public void PressPlay() { state.PressPlay(this); }
        public void PressAudioSource() { state.PressAudioSource(this); }
    }
}
