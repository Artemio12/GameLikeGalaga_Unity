using UnityEngine;

public class SimpleAxisMovement : ITypeMovement
{
    private Transform transform;

    private bool isHorizontaled;

    private float speed;
    public float Speed
    {
        set { this.speed = value; }
    }
  
    public SimpleAxisMovement(Transform transform) 
    {
        this.transform = transform;
    }

    public SimpleAxisMovement(Transform transform, bool isHorizontaled):this(transform)
    {
        this.isHorizontaled = isHorizontaled;
    }

    public void Move(Vector3 direction)
    {
        if (isHorizontaled)
        {
            direction.x += speed * Time.deltaTime;
        }
        else direction.y -= speed * Time.deltaTime;

        transform.Translate(direction);       
    }
}