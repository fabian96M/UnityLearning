using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    Vector3 miPos;
    public Transform nuevaPos;
    // Start is called before the first frame update
    void Start()
    {
        miPos.Set(nuevaPos.position.x, nuevaPos.position.y, 0);
        transform.position = miPos;
    }
    

  
}
