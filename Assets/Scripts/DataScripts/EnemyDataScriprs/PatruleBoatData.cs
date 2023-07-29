using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/PatrulBoat")]
public class PatruleBoatData : BaseEnemyData
{
    [SerializeField] private float amplitude;

    public override void SetParametersInFactory(BaseMovementFactory movementFactory)
    {
        SetIsHorizontaledInFactory(movementFactory);
        movementFactory.Amplitude = amplitude;
    }
}
