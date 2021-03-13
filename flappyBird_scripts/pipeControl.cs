using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeControl : MonoBehaviour
{
    
    public float speed = 1;
   
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            scoreControl.score++;
        }
    }
}
