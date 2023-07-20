using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "GameData/Projectile",order = 51)]
public class ProjectileData : ScriptableObject
{
    [Header("Base parameters")]
    [SerializeField] private string projectileName;
    public string ProjectileName => projectileName;

    //[SerializeField, Min(0)] private int damage;
    //public int Damage => damage;

    [Header("Spawn parameters")]
    [SerializeField] private Rigidbody projectileRigidbody;
    public Rigidbody ProjectileRigidbody => projectileRigidbody;
}
