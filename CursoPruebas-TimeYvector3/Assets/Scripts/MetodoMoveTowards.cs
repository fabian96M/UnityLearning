using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodoMoveTowards : MonoBehaviour
{
    // una variable y un componente transform publicos para designar un objetivo y velocidad a la que le obj contenedor del script se acercara
    public Transform objetivo;
    public float distanciaxseg;

    void Update()
    {
        //Se almacena la posicion actual en la variable pos
        Vector3 pos = transform.position;
        //Se modifica la posicion del objeto contenedor de scrpt usando el metodo move towards indicandole: (posicion de partida, objetivo, maxDistDelta)
        transform.position = Vector3.MoveTowards(pos, objetivo.position, distanciaxseg * Time.deltaTime);
    }
}
