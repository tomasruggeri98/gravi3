using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 1f;


    private void Awake()
    {
        Destroy(gameObject, life);
    }

    
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            
            Destroy(collision.gameObject);
        }
    } 

    
}
