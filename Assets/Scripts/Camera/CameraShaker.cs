using DG.Tweening;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] private Transform shakedCamera;
    [SerializeField] private Vector3 positionStrenght;
    [SerializeField] private Vector3 rotationStrenght;
    [SerializeField] private float timeShake = 0.3f;

    public void Shake()
    {
        shakedCamera.DOComplete();
        shakedCamera.DOShakePosition(timeShake, positionStrenght);
        shakedCamera.DOShakeRotation(timeShake, rotationStrenght);
    }
}
