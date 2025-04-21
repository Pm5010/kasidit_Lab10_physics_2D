using UnityEngine;

public class CamereFollow2D : MonoBehaviour
{
    private Vector3 offser = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    
    [SerializeField] private Transform target;
    
    private void Update()
    {
        Vector3 targetPosition = target.position + offser;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
