using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        
        float moveInput = Input.GetAxis("Horizontal");
        
        transform.position += new Vector3(moveInput * moveSpeed * Time.deltaTime, 0, 0);
    }
}