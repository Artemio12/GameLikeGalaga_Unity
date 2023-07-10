using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : Controller
{
    [Header("Type of enemy")]
    [SerializeField] private EnemyData enemyData;
    [Header("SineMovement")]
    [SerializeField] private float amplitude;
    
    private void Awake()
    {
        SetFactory(new SimpleMovementFactory(this.transform, enemyData.EnemySpeed, enemyData.IsReversed));
        WaveWidth(amplitude);
        Horizontal(enemyData.IsHorizontaled);

        SetTypeMovement(GetMovement(enemyData.Movement));
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
