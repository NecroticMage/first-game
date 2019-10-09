using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject camBind;
    public Transform camTransform;
    private Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = camBind.transform;
        camTransform = pos;
        
    }
}

//this.AddForce(1,1,1)
//Input.getKey("d")
