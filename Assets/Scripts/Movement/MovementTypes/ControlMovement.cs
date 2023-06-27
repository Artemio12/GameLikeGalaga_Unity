using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class ControlMovement : ITypeMovement
{
    public Transform transform;

    private float roll;
    private float pitch;

    private float speed;
    public float Speed 
    {
        set { this.speed = value; }
    }
   
    public ControlMovement(Transform transform)
    {
        this.transform = transform;
    }

    public ControlMovement(Transform transform, float roll, float pitch) :this(transform)
    {
        this.roll = roll;
        this.pitch = pitch;
    }

    public void Move(Vector3 direction)
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        direction.x += xAxis * speed * Time.deltaTime;
       // direction.y += yAxis * speed * Time.deltaTime;

        transform.Translate(direction, Space.World);

        transform.rotation = Quaternion.Euler(yAxis * roll , xAxis * pitch, 0);
    }
}
