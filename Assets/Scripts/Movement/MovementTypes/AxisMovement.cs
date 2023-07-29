using UnityEngine;

public class AxisMovement : ITypeMovement
{
    private Rigidbody rigidbody;
    private bool isHorizontaled;

    private float speed;
    public float Speed
    {
        set { this.speed = value; }
    }

    public AxisMovement(Rigidbody rigidbody, bool isHorizontaled)
    {
        this.rigidbody = rigidbody;
        this.isHorizontaled = isHorizontaled;
    }

    public void Move(Vector3 direction)
    {
        if (isHorizontaled)
        {
            direction.x = speed;
        }
        else direction.y = -speed;

        rigidbody.velocity = direction;
    }
}