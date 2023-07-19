using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/Enemies/PatrulBoat")]
public class PatruleBoatData : BaseEnemyData
{
    [SerializeField] private float amplitude;
    //public float Amplitude => amplitude;
    public override void SetParemeterInFactory(SimpleMovementFactory movementFactory)
    {
        SetIsHorizontaledInFactory(movementFactory);
        movementFactory.Amplitude = amplitude;
    }
}
