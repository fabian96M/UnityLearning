using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour{

    Renderer color;
     private void OnMouseEnter()
     {
         color = GetComponent<Renderer>();
         color.material.color = Color.red;
        print("el mouse ha entrado en contacto con el objeto");

     }
    private void OnMouseOver()
    {
        color.material.color = Color.blue;
        print("el mouse esta en contacto con el objeto ahora");
    }

    private void OnMouseExit()
    {
        color.material.color = Color.green;
    }

}
