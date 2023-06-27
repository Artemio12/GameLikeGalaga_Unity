using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : Controller
{
    [Header("Type of movement")]
    [SerializeField] protected EnumMovement movement;
   
    [Header("Defolt movement parameters")]
    public Transform enemyTransform;
    [SerializeField] private float enemySpeed;
    [SerializeField] private bool isHorizontaled;
    [SerializeField] private bool isReversed;

    [Header("SineMovement")]
    [SerializeField] private float waveWidth;
    

    private void Awake()
    {
        SetFactory(new SimpleMovementFactory(enemyTransform, enemySpeed,isReversed));
        WaveWidth(waveWidth);
        Horizontal(isHorizontaled);

        SetTypeMovement(GetMovement(movement));
    }

    private void FixedUpdate()
    {
        DoMove();
    }

    private void DoMove()
    {
        Move(direction);
    }

    public bool Horizontal(bool horizontal)
    {
        movementFactory.IsHorisontaled = horizontal;
        return movementFactory.IsHorisontaled;
    }

    public float WaveWidth(float width)
    {
        movementFactory.WaveWidth = width;
        return movementFactory.WaveWidth;
    }
}
