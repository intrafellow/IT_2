using System;

namespace IT_2_App.Models;

public interface IVoiceCapable
{
    event EventHandler VoiceGiven;
    void GiveVoice();
} 