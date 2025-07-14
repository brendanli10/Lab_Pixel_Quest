using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello";
    int var1 = 3;
    // Start is called before the first frame update
    //We combined var1 and var2
    void Start()
    {
        string variable2 = " Hi how are you today" +
            "";
        Debug.Log("Hello World");
        Debug.Log(variable1 + variable2)
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(var1++);

        
    }
}
