using UnityEngine;

public class LaserGun :  ITypeShootable
{
    private Transform firePoint;
    private LineRenderer beam;
    private float maxLength;
    private float damage = 0.3f;

    public LaserGun(Transform firePoint, LineRenderer beam, float maxLength)
    {
        this.firePoint = firePoint;
        this.beam = beam;
        this.maxLength = maxLength;
    }

    public void Attack()
    {
        Ray ray = new Ray(firePoint.position, firePoint.up);
        bool cast = Physics.Raycast(ray, out RaycastHit hit, maxLength);
        Vector3 hitPosition = cast ? hit.point : firePoint.position + firePoint.up * maxLength;
        beam.enabled = true;
        beam.SetPosition(0, firePoint.position);
        beam.SetPosition(1, hitPosition);

        if (cast && hit.collider.TryGetComponent(out Health health))
        {
            health.TakeDamage(damage * Time.fixedDeltaTime);
        }
    }
}
