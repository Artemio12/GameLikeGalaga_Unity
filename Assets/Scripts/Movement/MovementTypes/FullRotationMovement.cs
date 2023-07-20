using UnityEngine;

public class FullRotationMovement : ITypeMovement
{
    private Transform transform;
    private float speed;
    public FullRotationMovement(Transform transform) 
    { 
        this.transform = transform;
    }
    public float Speed 
    {
        set { this.speed = value; }
    }

    public void Move(Vector3 direction)
    {
        direction = transform.forward * speed;
        transform.Rotate(direction);
    }
   
}
