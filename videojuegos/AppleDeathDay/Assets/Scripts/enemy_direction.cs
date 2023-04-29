using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_direction : MonoBehaviour
{
    private SpriteRenderer rnderer;
    // Start is called before the first frame update
    void Start()
    {
        rnderer = GetComponent<SpriteRenderer>();
        var player = GameObject.Find("Manzana").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var player = GameObject.Find("Manzana").transform;
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if(angle >= 90){
            rnderer.flipY = false;
        }
        else if(angle >= -90){
            rnderer.flipY = true;
        }
    }
}
