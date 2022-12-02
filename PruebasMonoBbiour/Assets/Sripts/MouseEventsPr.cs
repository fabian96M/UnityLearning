using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEventsPr : MonoBehaviour
{
    Renderer color;
    // cambia el color a rojo cuando se presiona el boton 1 del mouse
    private void OnMouseDown()
    {
        color = GetComponent<Renderer>();
        color.material.color = Color.red;
    }
    // cambia el color a azul mientras el boton se mantenga pulsado
    private void OnMouseDrag()
    {
        color.material.color = Color.blue;
    }
    //cambia el color a verde cuando se suelta el boton del mouse
    private void OnMouseUp()
    {
        color.material.color = Color.green;
    }
    // cambia el color de render a negro cuando se suelta el boton sobre la GUI o collider del obj
    private void OnMouseUpAsButton()
    {
        color.material.color = Color.black;
    }
}
