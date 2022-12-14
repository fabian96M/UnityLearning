using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMultidireccional : MonoBehaviour
{
    //Vector3 dir = Vector3.left;
    Vector3 dir = Vector3.up;
    //Vector3 dir = Vector3.right;
    //Vector3 dir = Vector3.down;

    // Update is called once per frame
    void Update()
    {
        // a la posicion del objeto que contenga el script se le suma la direccion multiplicada por la cantidad de tiempo que transcurra entre cada frame
        transform.position += dir * Time.deltaTime;
    }
}
