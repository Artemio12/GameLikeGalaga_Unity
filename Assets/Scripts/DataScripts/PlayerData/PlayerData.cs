using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "GameData/Player")]
public class PlayerData : BaseCharacterData
{
    [Header("Movement parameters")]
    [SerializeField] private float roll;
    public float Roll => roll;  

    [SerializeField] private float pitch;
    public float Pitch => pitch;

    public override void SetParametersInFactory(BaseMovementFactory movementFactory)
    {
        movementFactory.Pitch = Pitch;
        movementFactory.Roll = Roll;
    }
}
