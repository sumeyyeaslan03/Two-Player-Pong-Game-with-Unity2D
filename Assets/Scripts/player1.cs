using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float hiz1;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0f,hiz1*Time.deltaTime,0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0f,-hiz1*Time.deltaTime,0f);
        }
        
    }



}
