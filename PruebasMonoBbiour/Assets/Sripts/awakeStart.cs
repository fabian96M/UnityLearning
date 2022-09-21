using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeStart : MonoBehaviour
{
    public Rigidbody ribdy;
    // Start is called before the first frame update
    void Start()
    {
        ribdy = GetComponent<Rigidbody>();
        print("Start");
    }
    private void Awake()
    {
        print("Awakeeee");
    }
    // Update is called once per frame
     void Update()
     {
         Debug.Log("Update uwu");
     }
    private void FixedUpdate()
    {
        ribdy.AddForce(10.0f * Vector3.up);
        print("fixiedUpdate prros");
    }
    private void LateUpdate()
    {
        print("llamado a lateUpdate");
    }
    private void OnEnable()
    {
        print("el script esta habilitado prro");
    }
    private void OnDisable()
    {
        print("el script esta desabilitao");
    }
}
