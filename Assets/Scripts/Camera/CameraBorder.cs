using UnityEngine;

public class CameraBorder : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Camera cam;
    [SerializeField] private float boarderDistanse;

    private float leftBoarder;
    private float rightBoarder;
    private float topBoarder;
    private float bottomBoarder;
     
    private void Start()
    {
        float distance = Vector3.Distance(playerTransform.position, cam.transform.position);
        leftBoarder = cam.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + boarderDistanse;
        rightBoarder = cam.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - boarderDistanse;
        topBoarder = cam.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - boarderDistanse;
        bottomBoarder = cam.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + boarderDistanse;
    }

    private void Update()
    {
        Vector3 pos = playerTransform.position;
        playerTransform.position = new Vector3(Mathf.Clamp(pos.x, leftBoarder, rightBoarder), Mathf.Clamp(pos.y, bottomBoarder, topBoarder), pos.z);
    }
}
