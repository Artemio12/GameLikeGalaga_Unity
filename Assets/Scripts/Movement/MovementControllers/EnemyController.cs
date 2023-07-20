using UnityEngine;

public class EnemyController : Controller
{
    [Header("Type of enemy")]
    [SerializeField] private BaseEnemyData enemyData;

    private void Awake()
    {
        SetFactory(new DefaultMovementFactory(this.transform, enemyData.EnemySpeed, enemyData.IsReversed));
        enemyData.SetParemeterInFactory(movementFactory);

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
}
