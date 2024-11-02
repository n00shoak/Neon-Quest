using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Acions_DefaultMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 3f; // Set rotation speed in the Inspector

    private Player_Data_Stats data;
    private Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        data = GetComponent<Player_Data_Stats>();
    }

    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.Mouse1) && rb.linearVelocity.magnitude < data.currentStats.maxSpeed)
        {
            rb.AddForce(transform.right * data.currentStats.acceleration);
        }
    }

    private void RotatePlayer()
    {
        // Get cursor position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 targetPosition = hit.point;
            Vector3 direction = targetPosition - transform.position;
            direction.Normalize();

            // Get rotation towards cursor on Z axis
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Create rotation angle
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

            // Progressive rotation towards target
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, data.currentStats.rotationSpeed * Time.deltaTime);
        }
    }
}
