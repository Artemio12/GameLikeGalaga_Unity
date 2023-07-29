using UnityEngine;

public class RamMovement : ITypeMovement
{
    private Transform transform;
    private Transform targetTransform;
    private Rigidbody rb;
    private float speed;
    public RamMovement(Transform transform)
    {
        this.transform = transform;
    }

    public float Speed 
    { 
        set { this.speed = value; } 
    }

    public void Move(Vector3 direction)
    {

    }
}
