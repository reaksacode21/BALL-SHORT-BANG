using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    bool isOn=false;
    public void btnclick()
    {
        isOn = true;
        FindObjectOfType<spamdice>().spawnOFdice();
        FindObjectOfType<manager>().handGame();
    }
     void Update()
    {
        if (isOn)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
       
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

   
}
