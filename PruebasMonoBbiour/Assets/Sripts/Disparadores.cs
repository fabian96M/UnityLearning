using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparadores : MonoBehaviour
{
    //public object other;
    //Revisar que el objeto tenga tildada la opcion "is trigger" (es disparador)
    //llamado cuando el colisionador entra en contacto con el disparador
    private void OnTriggerEnter(Collider other)
    {
        print("La accion fue disparada");
    }
    //llamado mientras el colisionador este en contacto con el disparador con el que este
    private void OnTriggerStay(Collider other)
    {
        print("El disparo se esta efectuando");
    }
    //Es llamado cuando el colisionador pierde el contacto con el disparador que se le aplique
    private void OnTriggerExit(Collider other)
    {
        print("El disparo dejo de efectuarse");
    }
}
