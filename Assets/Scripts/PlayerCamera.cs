using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public float sens;
    private float xrot;
    private float mouseX, mouseY;
    
    public bool menuopen;
    
    public Transform OtherCamera;
    
    public Transform Player;

    void Update()
    {
        if (!menuopen)
        {
            if (Cursor.lockState != CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            mouseX = Input.GetAxis("Mouse X") * sens / 250;
            mouseY = Input.GetAxis("Mouse Y") * sens / 250;
            
            xrot -= mouseY;
            xrot = Mathf.Clamp(xrot, -90, 90);

            transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);

            Player.Rotate(Vector3.up * mouseX);
        } else if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
