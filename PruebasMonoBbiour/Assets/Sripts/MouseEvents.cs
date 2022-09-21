using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour{

    Renderer color;
    private void OnMouseEnter()
    {
        color = GetComponent<Renderer>();
        color.material.color = Color.red;

    }
    private void OnMouseOver()
    {
        color.material.color = Color.blue;
    }

    private void OnMouseExit()
    {
        color.material.color = Color.green;
    }

}
