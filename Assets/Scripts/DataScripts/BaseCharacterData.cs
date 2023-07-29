using UnityEngine;

public abstract class BaseCharacterData : ScriptableObject
{
    [Header("Base Parameters")]
    [SerializeField] protected EnumMovement movement;
    public EnumMovement Movement => movement;

    [SerializeField, Min(0)] protected float health;
    public float Health => health;

    [SerializeField, Min(0)] protected float speed;
    public float Speed => speed;

    [SerializeField] protected bool isReversed;
    public bool IsReversed => isReversed;

    [SerializeField] protected Rigidbody rigidbody;
    public Rigidbody Rigidbody => rigidbody;

    public abstract void SetParametersInFactory(BaseMovementFactory movementFactory);
}
