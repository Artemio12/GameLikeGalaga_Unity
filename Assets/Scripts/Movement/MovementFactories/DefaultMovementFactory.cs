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

public class DefaultMovementFactory : BaseMovementFactory
{
    public DefaultMovementFactory(Transform transform, float speed) : base(transform, speed) { }
    public DefaultMovementFactory(Transform transform,float speed, bool isReversed): base(transform, speed, isReversed) { }

    protected override ITypeMovement CreateMovement(EnumMovement enumMovement)
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
                typeMovement = new SineMovement(transform, Amplitude, IsHorisontaled);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.MathTraectoryMovement:
                typeMovement = new MathTraectoryMovement(transform,Amplitude);
                typeMovement.Speed = speed; 
                break;
            case EnumMovement.FullRotationMovement:
                typeMovement = new FullRotationMovement(transform);
                typeMovement.Speed = speed;
                break;
            default:
                Debug.Log("Данного движения не существует");
                break;
        }
        return typeMovement;
    }
}
