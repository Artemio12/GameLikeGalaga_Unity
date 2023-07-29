using UnityEngine;

public class FullRotationMovement : ITypeMovement
{
    private Rigidbody rigidbody;
    private float speed;
    public FullRotationMovement(Rigidbody rigidbody) 
    { 
        this.rigidbody = rigidbody;
    }
    public float Speed 
    {
        set { this.speed = value; }
    }

    public void Move(Vector3 direction)
    {
       direction.z = speed;
       rigidbody.AddTorque(direction);
    }
}
