using UnityEngine;

public enum EnumMovement
{
    None = 0,
    ControlMovement = 1,
    SimpleAxisMovement = 2,
    SineMovement = 3,
    MathTraectoryMovement = 4,
    FullRotationMovement = 5,
    RamMovement = 6,
}

public abstract class BaseMovementFactory
{  
    protected float speed;
    public float Speed
    {
        protected get { return speed; }
        set
        {
            if (value >= 0)
            {
                this.speed = value;
                if (this.speed == 0) Debug.Log("speed == 0");
            }
            else Debug.LogError("Error: Speed < 0");
        }
    }

    public float Roll { protected get; set; }
    public float Pitch { protected get; set; }
    public float Amplitude { protected get; set; }
    public bool IsHorisontaled { protected get; set; }

    public BaseMovementFactory(float speed, bool isReversed)
    {
        this.Speed = speed;
        if (isReversed) this.speed = -this.Speed;
    }

    public ITypeMovement GetMovement(EnumMovement movement)
    {
        ITypeMovement typeMovement = CreateMovement(movement);
        return typeMovement;
    }

    protected abstract ITypeMovement CreateMovement(EnumMovement enumMovement);
}
