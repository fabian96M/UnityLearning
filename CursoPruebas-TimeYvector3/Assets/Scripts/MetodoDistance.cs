using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodoDistance : MonoBehaviour
{
    public Transform puntoB;
    void Start()
    {
        // la variable dist se crea para asignarle el calculo de la distancia entre el obj contenedor del script y el objeto designado publicamente como puntoB
        float dist = Vector3.Distance(transform.position, puntoB.position);
        //Se devuelve por consola el resultado del calculo 
        print("La distancia entre ambos objetos es de : " + dist);
    }
}
