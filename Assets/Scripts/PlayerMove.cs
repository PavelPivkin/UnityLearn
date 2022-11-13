using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 10.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);       
    }
}
