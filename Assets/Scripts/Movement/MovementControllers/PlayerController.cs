
using UnityEngine;

public class PlayerController : Controller
{
    [Header("Motion parameters")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerRoll;
    [SerializeField] private float playerPitch;

    public float PlayerSpeed => playerSpeed;

    public void Awake()
    {
        SetFactory(new SimpleMovementFactory(playerTransform,playerSpeed));
        SetRoll(playerRoll);
        SetPitch(playerPitch);
       
        SetTypeMovement(GetMovement(EnumMovement.ControlMovement));
    }
    
    public void FixedUpdate()
    {
        DoMove();
    }

    private void DoMove()
    {
        Move(direction);
    }

    private float SetRoll(float roll)
    {
        movementFactory.Roll = roll;
        return movementFactory.Roll;
    }

    private float SetPitch(float pitch) 
    {
        movementFactory.Pitch = pitch;
        return movementFactory.Pitch;
    }
}
