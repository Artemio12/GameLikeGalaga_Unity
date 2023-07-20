using UnityEngine;

public abstract class BaseMovementFactory
{
    protected Transform transform;
    protected float speed;
    public float Speed
    {
        get { return speed; }
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
    public bool IsHorisontaled { protected get; set; }
    public float Amplitude { protected get; set; }
    public float Radius { protected get; set; }

    public BaseMovementFactory(Transform transform, float speed)
    {
        this.transform = transform;
        this.Speed = speed;
    }

    public BaseMovementFactory(Transform transform, float speed, bool isReversed): this(transform, speed) 
    {
        if (isReversed) this.speed = -this.Speed;
    }

    public ITypeMovement GetMovement(EnumMovement movement)
    {
        ITypeMovement typeMovement = CreateMovement(movement);
        return typeMovement;
    }

    protected abstract ITypeMovement CreateMovement(EnumMovement enumMovement);
}
