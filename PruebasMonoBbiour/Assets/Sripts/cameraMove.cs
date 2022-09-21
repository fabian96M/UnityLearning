using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Rigidbody ribdy;
    // Start is called before the first frame update
    void Start()
    {
        ribdy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        ribdy.AddForce(10.0f* Vector3.up);
    }
}
