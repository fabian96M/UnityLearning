using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    //para obtener la posicion del objeto que contenga el script
    Vector3 miPos;
    //para referenciar una posicion mediante otro objeto
    public Transform nuevaPos;
    void Start()
    {
        //modificamos los valores de posicion del objeto x los de la posicion x e y del objeto de referencia
        miPos.Set(nuevaPos.position.x, nuevaPos.position.y, 0);
        // cambiamos la posicion del obj contenedor del script a la especificada en la linea anterior
        transform.position = miPos;
    }
    

  
}
