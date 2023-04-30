using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.GetComponent<enemy_movement>() != null)
        {
            
            if (GameObject.Find("Score").GetComponent<score_>())
            {
                score_.scoreValue += 10;
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
       }
    }
}
