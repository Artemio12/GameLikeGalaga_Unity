using UnityEngine;
// Need Use Singleton
public class ControlMovement : ITypeMovement
{
    private Rigidbody rigidbody;
    private float roll;
    private float pitch;

    private float speed;
    public float Speed 
    {
        set { this.speed = value; }
    }

    public ControlMovement(Rigidbody rigidbody)
    {
        this.rigidbody = rigidbody;
    }

    public ControlMovement(Rigidbody rigidbody, float roll, float pitch) : this(rigidbody)
    {
        this.roll = roll;
        this.pitch = pitch;
    }

    public void Move(Vector3 direction)
    {
        direction.x = speed * Input.GetAxis("Horizontal");
        direction.y = speed * Input.GetAxis("Vertical");
        
        rigidbody.velocity = direction;
        rigidbody.rotation = Quaternion.Euler(direction.y * roll, direction.x * pitch, 0f);
    }
}
