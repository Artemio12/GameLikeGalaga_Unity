using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITypeMovement
{
    public float Speed { set;}
    public void Move(Vector3 direction);
}
