using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaTimeSale : MonoBehaviour
{
    public float EscalaDeTiempo;
    // Update is called once per frame
    void Update()
    {
        /*La escala de tiempo se define para ralentizar o acelerar
         el tiempo usando magnitudes desde 0 a 1 para ralentizar y mas de 1 para acelerar*/
        Time.timeScale = EscalaDeTiempo;
    }
}
