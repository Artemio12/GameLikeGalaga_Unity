using UnityEngine;

public class NonPhysicalMovementFactory : BaseMovementFactory
{
    private Transform transform;
    public NonPhysicalMovementFactory(Transform transform, float speed, bool isReversed): base(speed, isReversed)
    {
        this.transform = transform;
    }

    protected override ITypeMovement CreateMovement(EnumMovement enumMovement)
    {
        throw new System.NotImplementedException();
    }

}
