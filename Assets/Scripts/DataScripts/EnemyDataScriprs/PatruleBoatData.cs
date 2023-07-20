using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/PatrulBoat")]
public class PatruleBoatData : BaseEnemyData
{
    [SerializeField] private float amplitude;

    public override void SetParemeterInFactory(BaseMovementFactory movementFactory)
    {
        SetIsHorizontaledInFactory(movementFactory);
        movementFactory.Amplitude = amplitude;
    }
}
