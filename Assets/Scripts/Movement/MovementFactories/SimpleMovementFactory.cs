using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnumMovement
{
    None = 0,
    ControlMovement = 1,
    SimpleAxisMovement = 2,
    SineMovement = 3,
}

public class SimpleMovementFactory 
{
    private Transform transform;

    private float roll;
    public float Roll { get; set; }

    private float pitch;
    public float Pitch { get; set; }
   
    private bool isHorisontaled;
    public bool IsHorisontaled { get; set; }

    private float waveWidth;
    public float WaveWidth { get; set; }

    private float speed;
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

    public SimpleMovementFactory(Transform transform, float speed) 
    {
        this.transform = transform;
        this.Speed = speed;
    }

    public SimpleMovementFactory(Transform transform,float speed, bool isReversed): this(transform, speed)
    {
        if (isReversed) this.speed = -this.Speed;
    }

    public ITypeMovement CreateMovement(EnumMovement enumMovement)
    {
        ITypeMovement typeMovement = null;
        switch (enumMovement)
        {
            case EnumMovement.ControlMovement:
                typeMovement = new ControlMovement(transform, Roll, Pitch);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.SimpleAxisMovement:
                typeMovement = new SimpleAxisMovement(transform, IsHorisontaled);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.SineMovement:
                typeMovement = new SineMovement(transform,WaveWidth,IsHorisontaled);
                typeMovement.Speed = speed;
                break;
            default:
                Debug.Log("Данного движения не существует");
                break;
        }
        return typeMovement;
    }
}
