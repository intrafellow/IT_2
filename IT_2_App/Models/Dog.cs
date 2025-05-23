using System;

namespace IT_2_App.Models;

public class Dog : Creature, IVoiceCapable
{
    public event EventHandler? VoiceGiven;

    public Dog(double maxSpeed, double speedStep) : base(maxSpeed, speedStep)
    {
    }

    public void GiveVoice()
    {
        VoiceGiven?.Invoke(this, EventArgs.Empty);
    }

    public override string GetInfo()
    {
        return $"Dog - {base.GetInfo()}";
    }
} 