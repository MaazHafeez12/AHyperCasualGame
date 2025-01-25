using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 InitialPosition;
    [SerializeField] private Vector3 MaxPosition;
    [SerializeField] [Range(0,1)] private float Progress;

    private void Awake()
    {
        transform.localPosition = InitialPosition;
    }
    private void LateUpdate()
    {
        transform.localPosition = Vector3.Lerp(InitialPosition, MaxPosition, Progress);
    }
}
