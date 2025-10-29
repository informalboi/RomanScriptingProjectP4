using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //create my integer variable
    public int informalboi = 5;
    //Start is called before the first frame update
    void Start()
    {
        // run my variable thru my function
        informalboi = MultiplyByTwo(informalboi);
        Debug.Log(informalboi);
    }

    // Update is called onnce per frame
    void Update()
    {
       
    }
    //create the multiply by two function
    int MultiplyByTwo (int number)
    {   //create a local variable
        int result;
        //multiplying the number by two
        result = number * 2;
        //return the value 
        return result;
       
    }

    
}
