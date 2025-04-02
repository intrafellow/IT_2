using System;

namespace Animal.Models

{
    public interface IVoiceCapable
    {
        event EventHandler VoiceGiven;

        void GiveVoice();
    }
}