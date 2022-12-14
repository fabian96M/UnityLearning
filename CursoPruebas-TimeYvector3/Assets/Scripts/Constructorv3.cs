using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructorv3 : MonoBehaviour
{
    /*creacion de un vector tridimensional*/
    Vector3 nuevoVector = new Vector3(2, 1, 5);

    /*propiedades vector3*/

    //propiedad left Vector3(-1,0,0)
    //Vector3 nuevoVector = Vector3.left;

    //propiedad right /es la taquigrafia para escribir Vector3(1,0,0)
    //Vector3 nuevoVector = Vector3.right;

    //propiedad up /es la taquigrafia para escribir Vector3(0,1,0)
    //Vector3 nuevoVector = Vector3.up;

    //propiedad down /es la taquigrafia para escribir Vector3(0,-1,0)
    //Vector3 nuevoVector = Vector3.down;

    //propiedad forward /es la taquigrafia para escribir Vector3(0,0,1)
    //Vector3 nuevoVector = Vector3.forward;

    //propiedad back /es la taquigrafia para escribir Vector3(0,0,-1)
    //Vector3 nuevoVector = Vector3.back;

    //propiedad one /es la taquigrafia para escribir Vector3(1,1,1)
    //Vector3 nuevoVector = Vector3.one;

    //propiedad zero /es la taquigrafia para escribir Vector3(0,0,0)
    //Vector3 nuevoVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //asigna movimiento a la posicion que marca el vector nombrado
        this.transform.position = nuevoVector;
        
    }

   
}
