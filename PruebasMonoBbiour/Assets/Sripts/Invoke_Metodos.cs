using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Metodos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EscribirHola", 0.2f);
    }

    // Este metodo te saluda x consola
    void EscribirHola()
    {
        Debug.Log("HOLAAAAAAAAAAAAAAAAAAAA");
    }
}
