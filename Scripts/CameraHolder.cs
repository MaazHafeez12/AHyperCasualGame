
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 InitialRotation;
    private void Update()
    {
        transform.position=new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
        playerTransform.eulerAngles=new Vector3(playerTransform.eulerAngles.x + InitialRotation.x, playerTransform.eulerAngles.y + InitialRotation.y, 0);
    }
}
