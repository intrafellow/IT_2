using System;

namespace IT_2_App.Models;

public abstract class Creature
{
    protected double Speed { get; set; }
    protected double MaxSpeed { get; }
    protected double SpeedStep { get; }
    public bool IsMoving { get; protected set; }

    protected Creature(double maxSpeed, double speedStep)
    {
        MaxSpeed = maxSpeed;
        SpeedStep = speedStep;
        Speed = 0;
        IsMoving = false;
    }

    public virtual void Move()
    {
        if (!IsMoving)
        {
            IsMoving = true;
            Speed = SpeedStep;
        }
        else
        {
            Speed = Math.Min(Speed + SpeedStep, MaxSpeed);
        }
    }

    public virtual void Stand()
    {
        IsMoving = false;
        Speed = 0;
    }

    public virtual string GetInfo()
    {
        return $"Speed: {Speed:F1}, IsMoving: {IsMoving}";
    }
} 