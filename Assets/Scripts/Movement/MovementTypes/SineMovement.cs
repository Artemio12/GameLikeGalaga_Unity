using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : ITypeMovement
{
    private Transform transform;

    private bool isHorizontaled;

    private float frequency;
    private float width;
    private float angle;

    public float Speed
    {
        set { this.frequency = value; }
    }

    public SineMovement(Transform transform, float width, bool isHorizontaled)
    {
        this.transform = transform;
        this.width = width;
        this.isHorizontaled = isHorizontaled;
    }

    public void Move(Vector3 direction)
    {
        //float angle =  2 * Mathf.PI * (timer.TimeCount() / frequency);
         angle +=  frequency * Time.deltaTime ;

        if (isHorizontaled)
        {
            direction.y +=  width * Mathf.Sin(angle);
        }
        else direction.x += width * Mathf.Sin(angle);

        transform.Translate(direction);
    }
}
