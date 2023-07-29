using UnityEngine;
using UnityEngine.Serialization;

public abstract class BaseEnemyData : BaseCharacterData
{
    [SerializeField, Min(0), FormerlySerializedAs("enemyDeathPoints")] protected int deathPoints;
    public int DeathPoints => deathPoints;

    [Header("Movement parameters")]
    [SerializeField] protected bool isHorizontaled;
    public bool IsHorizontaled => isHorizontaled;

    [Header("Spawn parameters")]
    [SerializeField, Min(0), FormerlySerializedAs("poolEnemyCount")] protected int poolCount;
    public int PoolCount => poolCount;

    [SerializeField] protected bool isAutoExpanded;
    public bool IsAutoExpanded => isAutoExpanded;

    protected void SetIsHorizontaledInFactory(BaseMovementFactory movementFactory)
    {
        movementFactory.IsHorisontaled = this.IsHorizontaled;
    }
}
