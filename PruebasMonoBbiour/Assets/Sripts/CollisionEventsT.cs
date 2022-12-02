using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEventsT : MonoBehaviour
{
    //object otroObj;
    // Escribe en caso de detectar una colision con el rigidBody
    private void OnCollisionEnter(Collision otroObj)
    {
        print("Los objetos han colisionado");
    }
    //Escribe Mientras detecte que objetos estan en Con el Rgbody
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("El objeto ha estado en contacto con otro");
    }
    //Escribe en caso de que detecte que una collision entre objetos ha finalizado
    private void OnCollisionExit(Collision collision)
    {
        print("El contacto entre objetos ha finalizado");
    }
}
