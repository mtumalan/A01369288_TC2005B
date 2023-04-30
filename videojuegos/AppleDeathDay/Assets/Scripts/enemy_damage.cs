using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_damage : MonoBehaviour
{
    public health h;

    void Start()
    {
        h = GameObject.Find("Manzana").GetComponent<health>();
    }

    public void OnCollisionEnter2D(Collision2D col)
     {
         if (col.gameObject.CompareTag("Player")) 
         {
            
             //health h = col.gameObject.GetComponent<health>();
             if (h != null)
             {
                h.Damage(1);
                Destroy(gameObject);
             }

                 
         }
         
     }
}
