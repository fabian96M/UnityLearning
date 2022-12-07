using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Metodos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*el metodo invoke invoca un metodo que cancela las invocaciones
         El metodo invoke repeating invoca un metodo que escribe primero con un tiempo de retraso de 1 y luego lo hace cada 5 segs*/
        
        InvokeRepeating("EscribirHola", 1.0f, 5.0f);
        //cancela las invocaciones y lo anuncia x texto
        Invoke("CancelarInvocaciones", 10.0f);
    }

    // Este metodo te saluda x consola
    void EscribirHola()
    {
        print("HOLAAAAAAAAAAAAA Holanda");
    }
    //se invoca un metodo que finaliza las invocaciones y se anuncia x texto 
    void CancelarInvocaciones()
    {
        CancelInvoke();
        print("invocaciones finalizadas");
    }
}
