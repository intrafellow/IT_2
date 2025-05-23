using System;

namespace IT_2_App.Models;

public class Panther : Creature, IVoiceCapable, ITreeClimber
{
    public event EventHandler? VoiceGiven;
    public bool IsOnTree { get; private set; }

    public Panther(double maxSpeed, double speedStep) : base(maxSpeed, speedStep)
    {
    }

    public void GiveVoice()
    {
        VoiceGiven?.Invoke(this, EventArgs.Empty);
    }

    public void ClimbTree()
    {
        if (!IsOnTree)
        {
            IsOnTree = true;
            IsMoving = false;
            Speed = 0;
        }
    }

    public void GetDownFromTree()
    {
        if (IsOnTree)
        {
            IsOnTree = false;
        }
    }

    public override void Move()
    {
        if (IsOnTree)
        {
            return;
        }
        base.Move();
    }

    public override void Stand()
    {
        if (IsOnTree)
        {
            return;
        }
        base.Stand();
    }

    public override string GetInfo()
    {
        return $"Panther - {base.GetInfo()}, IsOnTree: {IsOnTree}";
    }
} 