using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClassPractice : MonoBehaviour
{
   

   
    public float dtime;
    void Update()
    {
        /** DeltaTime devuelve la cantidad de tiempo en segundos transcurridos 
         * desde que se completó el último cuadro. Este valor varía en función de los fotogramas 
         * por segundo (FPS) a la que se ejecuta su juego o aplicación.**/
        dtime = Time.deltaTime;
        print("Tiempo delta = " + dtime);
    }

}
