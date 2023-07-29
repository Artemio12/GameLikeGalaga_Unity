using UnityEngine;

public class MathTraectoryMovement : ITypeMovement
{
    private Rigidbody rigidbody;
    private Timer timer = new Timer();
    private float radius;

    private float speed;
    public float Speed
    {
        set { this.speed = value; }
    }

    public MathTraectoryMovement(Rigidbody rigidbody, float radius)
    {
        this.rigidbody = rigidbody;
        this.radius = radius;
    }

    public void Move(Vector3 direction)
    {
        direction.x = radius * Mathf.Sin(speed * timer.TimeCount());
        direction.y = radius * Mathf.Cos(speed * timer.TimeCount());
       
        rigidbody.velocity = direction;
    }
}
