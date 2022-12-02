using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadoresPrctca : MonoBehaviour
{
    Renderer color;

    //public object other;
    //Revisar que el objeto tenga tildada la opcion "is trigger" (es disparador)
    //llamado cuando el colisionador entra en contacto con el disparador
    private void OnTriggerEnter(Collider other)
    {
        color = other.gameObject.GetComponent<Renderer>();
        color = GetComponent<Renderer>();
    }
    //llamado mientras el colisionador este en contacto con el disparador con el que este
    private void OnTriggerStay(Collider other)
    {
        color.material.color = Color.blue;
    }
    //Es llamado cuando el colisionador pierde el contacto con el disparador que se le aplique
    private void OnTriggerExit(Collider other)
    {
        color.material.color = Color.red;
    }
}
