using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaVector3funciones : MonoBehaviour
{
    //se crea un vector con las posiciones 10 10 y 10 respectivamente
    Vector3 eje = new Vector3(10, 10, 10);
    // Start is called before the first frame update
    void Start()
    {
        //se asignan valores nuevos para las posiciones x y z
        eje.x = 5;
        eje.y = 5;
        eje.z = 0;
        // se asigna como nueva posicion al objeto que contenga el scrpt la posicion marcada por el vector3 "eje"
        this.transform.position = eje;
        // se devuelve la posicion que deberia haber adoptado el objeto que contiene el scrpt x consola
        print(" x: " + eje.x + " y: " + eje.y + " z: " + eje.z);
    }


}
