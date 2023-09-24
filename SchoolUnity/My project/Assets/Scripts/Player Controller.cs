using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float sensX;
    public float sensY;

    private void start()
    {
        //Lock Cursor in screen
        Cursor.lockstate = CursosLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //Mouse Input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
    }

}
