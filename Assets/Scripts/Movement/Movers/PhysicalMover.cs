using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PhysicalMover : BaseMover
{
    [Header("Type of character")]
    [SerializeField] private BaseCharacterData characterData;
    private Rigidbody body;

    private void Awake()
    {
        GetRigidbody();
        SetFactory(new PhysicalMovementFactory( body, characterData.Speed, characterData.IsReversed));
        characterData.SetParametersInFactory(movementFactory);

        SetTypeMovement(GetMovement(characterData.Movement));
    }

    private void FixedUpdate()
    {
        DoMove();
    }

    private void DoMove()
    {
        Move(direction);
    }

    private void GetRigidbody()
    {
        body = GetComponent<Rigidbody>();
    }

}
