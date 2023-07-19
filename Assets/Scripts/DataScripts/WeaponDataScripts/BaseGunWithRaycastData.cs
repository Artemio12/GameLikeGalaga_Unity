using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGunWithRaycastData : BaseGunData
{
    [SerializeField] protected LineRenderer lineRenderer;
    public LineRenderer LineRenderer => lineRenderer;

}
