using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    //una vrible publica para ajustar la sensibilidad del mouse
    public float mouseSensivity =80f;
    //un componente publico para asignar el componente transform de lo que sera reconocido como cuerpo del jugador
    public Transform playerBody;

    float xrotation = 0;
  

    // Update is called once per frame
    void Update()
    {
        /*dentro de cada frame se asigna a las variables mouseX y mouseY el valor de entrada de dicho eje multiplicado x el valor de sensibilidad y la escala de tiempo delta */
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xrotation -= mouseY;
        //Esta linea limita (clampea) la rotacion para que no supere mas de 90 o -90 grados cuando se mira hacia arriba o abajo
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);

        //Esta linea se ocupa de mover la vista de izq a derecha
        //Se aplica la rotacion multiplicando la posicion (0,1,0) por el valor que devuelva mouseX
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
