using UnityEngine;

public class SY_Propulsion : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed,maxSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.right * speed);
        }
    }
}
