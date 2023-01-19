using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensivity =80f;

    public Transform playerBody;

    float xrotation = 0;
  

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xrotation -= mouseY;

        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
