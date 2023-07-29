using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SineMovement : ITypeMovement
{
    private Timer timer = new Timer();
    private Rigidbody rigidbody;
    private bool isHorizontaled;

    private float speed;
    private float amplitude;
   
    public float Speed
    {
        set { this.speed = value; }
    }

    public SineMovement(Rigidbody rigidbody, float amplitude, bool isHorizontaled)
    {
        this.rigidbody = rigidbody;
        this.amplitude = amplitude;
        this.isHorizontaled = isHorizontaled;
    }

    public void Move(Vector3 direction)
    {
        if (isHorizontaled)
        {
            direction.x = amplitude * Mathf.Sin(speed * timer.TimeCount());
        }
        else direction.y = amplitude * Mathf.Sin(speed * timer.TimeCount());

        rigidbody.velocity = direction;
    }
}
