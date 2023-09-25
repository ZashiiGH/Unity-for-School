using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //CAMERA SCRIPT------------------------------------------------------

    public float sensitivity = 2.0f;
    public float minimumX = -90.0f;
    public float maximumX = 90.0f;

    private float rotationX = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
    
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the camera horizontally based on mouse input
        transform.localRotation *= Quaternion.Euler(0, mouseX, 0);

        // Calculate the new vertical rotation
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        // Apply the vertical rotation to the camera
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }

   
}