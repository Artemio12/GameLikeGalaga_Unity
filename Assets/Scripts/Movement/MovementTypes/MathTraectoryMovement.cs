using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathTraectoryMovement : ITypeMovement
{
    private Transform transform;
    private float speed;
    private float radius;
    private float angle;
   
    public float Speed
    {
        set { this.speed = value; }
    }

    public MathTraectoryMovement(Transform transform, float radius)
    {
        this.transform = transform;
        this.radius = radius;
    }

    public void Move(Vector3 direction)
    {
        angle += speed * Time.deltaTime;
        direction.y += radius * Mathf.Sin(angle);
        direction.x += radius * Mathf.Cos(angle);

        transform.Translate(direction);
    }
}
