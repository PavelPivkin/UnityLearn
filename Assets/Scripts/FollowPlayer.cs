using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform PlayerTransform;
    void LateUpdate()
    {
        transform.position = PlayerTransform.position; 
    }
}
