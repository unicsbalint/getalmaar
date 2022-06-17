namespace learning.State
{
    public abstract class AudioPlayerState
    {
        public abstract void PressPlay(AudioPlayer player);
        public abstract void PressAudioSource(AudioPlayer player);
    }
}