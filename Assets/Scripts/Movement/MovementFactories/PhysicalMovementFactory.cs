using UnityEngine;

public sealed class PhysicalMovementFactory : BaseMovementFactory
{
    private Rigidbody body;
    public PhysicalMovementFactory(Rigidbody rigidbody,float speed, bool isReversed): base (speed, isReversed)
    {
        this.body = rigidbody;
    }

    protected override ITypeMovement CreateMovement(EnumMovement enumMovement)
    {
        ITypeMovement typeMovement = null;
        switch (enumMovement)
        {
            case EnumMovement.ControlMovement:
                typeMovement = new ControlMovement(body, Roll, Pitch);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.SimpleAxisMovement:
                typeMovement = new AxisMovement(body, IsHorisontaled);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.SineMovement:
                typeMovement = new SineMovement(body, Amplitude, IsHorisontaled);
                typeMovement.Speed = speed;
                break;
            case EnumMovement.MathTraectoryMovement:
                typeMovement = new MathTraectoryMovement(body,Amplitude);
                typeMovement.Speed = speed; 
                break;
            case EnumMovement.FullRotationMovement:
                typeMovement = new FullRotationMovement(body);
                typeMovement.Speed = speed;
                break;
            default:
                Debug.Log("Данного движения не существует");
                break;
        }
        return typeMovement;
    }
}
