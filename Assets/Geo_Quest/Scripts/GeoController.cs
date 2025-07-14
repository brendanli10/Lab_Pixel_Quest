using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    //global vars
    string variable1 = "Hello";
    int var1 = 3;
    private Rigidbody2D rb;
    int var2 = 3;
    public int speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string variable2 = " Hi how are you today" +
            "";
        Debug.Log("Hello World");
        Debug.Log(variable1 + variable2);
        Debug.Log(variable1 + variable2);

    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        //Debug.Log(var1++);
        //moves the square to the right
        //transform.position += new Vector3(0.005f, 0, 0); */

    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log ("Hit");
        
        
    }
}

