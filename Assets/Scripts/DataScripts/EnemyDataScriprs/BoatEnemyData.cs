using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/Boat")]
public class BoatEnemyData : BaseEnemyData
{
    public override void SetParemeterInFactory(SimpleMovementFactory movementFactory)
    {
        SetIsHorizontaledInFactory(movementFactory);
    }
}
