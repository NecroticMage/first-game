using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject camBind;
    public Vector3 offset;
    public float focusSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camBind.transform.position + offset, Time.deltaTime * focusSpeed);
        
    }
}

//this.AddForce(1,1,1)
//Input.getKey("d")
