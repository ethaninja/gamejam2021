
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target; 
    private GameObject playerRef;

    public float smoothSpeed = 0.2f; //How fast the camera will follow the target
    public Vector3 offset; //offset camera on all 3 axis

    void Awake() 
    {
            //target = transform.Find("Player"); //Isn't working. For now you'll have to manually reference it in inspector
    }
    //LateUpdate runs right after the Update
    void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }

}
