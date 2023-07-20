using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/Boat")]
public class BoatEnemyData : BaseEnemyData
{
    public override void SetParemeterInFactory(BaseMovementFactory movementFactory)
    {
        SetIsHorizontaledInFactory(movementFactory);
    }
}
