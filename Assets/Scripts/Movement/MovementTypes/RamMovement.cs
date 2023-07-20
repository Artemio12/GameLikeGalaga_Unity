using UnityEngine;

public class RamMovement : MonoBehaviour
{
    private Transform transform;
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
