using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;  
    [SerializeField] float smoothSpeed = 2f;
    [SerializeField] Vector3 offset = new Vector3(0, 2, -5); 
    
    void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + target.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
