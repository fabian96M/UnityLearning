using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V3MetodosPublicos : MonoBehaviour
{
    Vector3 miPos;
    Transform nuevaPos;
    // Start is called before the first frame update
    public void Start()
    {
        miPos.Set(nuevaPos.position.x, nuevaPos.position.y, 0);
        transform.position = miPos; 
    }

}
