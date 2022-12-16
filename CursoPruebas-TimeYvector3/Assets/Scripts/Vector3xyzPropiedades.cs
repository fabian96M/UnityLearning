using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3xyzPropiedades : MonoBehaviour
{
    Vector3 eje = new Vector3(12, 15, 22);
    // Start is called before the first frame update
    void Start()
    {
        eje.x = 7;
        //Devuelve los valores para los valores establecidos dentro del vector3 de nombre "eje"
        print(" x: " + eje.x + " y: " + eje.y + " z: " + eje.z);
        //se modifican los valores para x, y, z respectivamente usando una referencia a las posiciones 0,1 y 2 de eje
        eje[0] = 1;
        eje[1] = 1;
        eje[2] = 2;
        //se deveuelven por texto los valores modificados en las lineas anteriores
        print("los nuevos valores para x,y,z son respectivamente : " + eje.x + " para x " + eje.y + " para y" + eje.z + " para el eje z");

    }

}
