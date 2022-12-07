using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokePractica2 : MonoBehaviour
{
    public GameObject objeto;
    void Start()
    {
        //se invoca 1 vez el metodo spawn
       // Invoke("spawn", 2.0f);
       //se invoca repetidas veces el metodo spawn 
        InvokeRepeating("spawn", 0.2f, 1.0f);

    }
    void spawn()
    {
        //se instancia un nuevo objeto selecto para multiplicarse
        Instantiate(objeto.gameObject);
    }
    private void Update()
    {
        //al presionar la tecla espacio se cancelan las invocaciones
        if (Input.GetKey("space"))
        {
            CancelInvoke();
        }
    }

}
