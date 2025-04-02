using System;

namespace Laba._2_Animal.Models
{
    public abstract class Creature
    {
        private double _currentSpeed;
        private readonly double _speedStep;
        private readonly double _maxSpeed;

        public double CurrentSpeed
        {
            get => _currentSpeed;
            protected set => _currentSpeed = Math.Clamp(value, 0, _maxSpeed);
        }

        public double MaxSpeed => _maxSpeed;

        public double SpeedStep => _speedStep;

        protected Creature(double maxSpeed, double speedStep)
        {
            _maxSpeed = maxSpeed > 0 ? maxSpeed : throw new ArgumentException("Max speed must be positive", nameof(maxSpeed));
            _speedStep = speedStep > 0 ? speedStep : throw new ArgumentException("The velocity stamp must be positive", nameof(speedStep));
            _currentSpeed = 0;
        }

        public abstract void Move();

        public abstract void Stand();

        public virtual string GetInfo()
        {
            return $"Speed: {CurrentSpeed:F1} из {MaxSpeed:F1}";
        }
    }
}