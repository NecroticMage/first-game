using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed;
    public float forwardModify;
    public float jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.mousePosition.x >= 10)
        {
            transform.rotation.y += 10;
        }*/
        //Debug.Log(Input.mousePosition.x);
        if(Input.GetKey("w"))
        {
            player.AddForce(0, 0, speed * forwardModify * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(0, 0, speed * Time.deltaTime *-1);
        }
        if (Input.GetKey("d"))
        {
            player.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            player.AddForce(0, jumpHeight, 0);
        }
    }
}
