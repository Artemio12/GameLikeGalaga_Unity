
using UnityEngine;

public class PlayerController : Controller
{
    [Header("Motion parameters")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerRoll;
    [SerializeField] private float playerPitch;

    public void Awake()
    {
        SetFactory(new SimpleMovementFactory(this.transform, playerSpeed));
        SetParametersInFactory();

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

    private void SetParametersInFactory()
    {
        movementFactory.Pitch = playerPitch;
        movementFactory.Roll = playerRoll;   
    }
}
