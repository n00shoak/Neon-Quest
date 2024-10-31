using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_ShipRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 3f; // Set rotation speed in the Inspector

    void Update()
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
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
