using UnityEngine;

public class LaserGun :  ITypeShootable
{
    private Transform firePoint;
    private LineRenderer beam;
    private float maxLength;
    private Timer timer = new Timer();

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

        if (Input.GetButton("Fire1"))
        {
            beam.enabled = true;
            beam.SetPosition(0, firePoint.position);
            beam.SetPosition(1, hitPosition);
        } else { beam.enabled = false; }
       
      
        //Debug.Log("вжжжжжиииииииииииу");
    }
}
