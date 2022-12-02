using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents2 : MonoBehaviour
{
    public Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    //cuando se presione el boton 1 sobre el collider o GUI se devolvera x consola un numero aleatorio entre 0 y 100
    private void OnMouseDown()
    {
        float rd = Random.Range(0, 100);
        print(rd);
    }
    //cambiara el color del objeto cuando se pulse y se mantenga pulsado el boton 1 sobre el objeto
    private void OnMouseDrag()
    {
        rend.material.color = Color.white * Time.deltaTime;
    }
    //Cuando deja de presionarse el boton
    private void OnMouseUp()
    {
        print("soltaste el boton");
    }
    //Cuando deja de presionarse el boton sobre el mismo GUI o collider sobre el que se presiono
    private void OnMouseUpAsButton()
    {
        print("... y lo soltaste sobre la misma superficie");
    }


}
