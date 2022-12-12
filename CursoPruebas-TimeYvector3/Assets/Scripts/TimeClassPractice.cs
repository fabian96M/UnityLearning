using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClassPractice : MonoBehaviour
{
   

   
    public float dtime;
    void Update()
    {
        /** DeltaTime devuelve la cantidad de tiempo en segundos transcurridos 
         * desde que se complet� el �ltimo cuadro. Este valor var�a en funci�n de los fotogramas 
         * por segundo (FPS) a la que se ejecuta su juego o aplicaci�n.**/
        dtime = Time.deltaTime;
        print("Tiempo delta = " + dtime);
    }

}
