using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    //global vars
 //   string variable1 = "Hello";
   // int var1 = 3;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
   // int var2 = 3;
    public int speed = 4;
    public string nextLevel = "Scene 2 GQ";
    public string thirdLevel = "Scene 3 GQ";
    public string EndPage = "Scene 4 GQ";
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        
          if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            sr.color = new Color (1,0,0); //red
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            sr.color = new Color (0,1,0); //green
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            sr.color = new Color(0,0,1); //blue
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "LVL2FINISH":
                {
                    SceneManager.LoadScene(thirdLevel);
                    break;
                }
            case "The End":
                {
                    SceneManager.LoadScene(EndPage);
                    break;
                }
            }
        }
        
    }





   /* Key Controls for Movement
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
        } */
