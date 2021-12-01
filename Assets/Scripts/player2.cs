using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
  public float hiz2;

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0f,hiz2*Time.deltaTime,0f);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0f,-hiz2*Time.deltaTime,0f);
        }

    }
}
