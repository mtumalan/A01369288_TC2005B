using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_rotation : MonoBehaviour
{
    private SpriteRenderer rnderer;
    [SerializeField] Transform player;
    void Start(){
    rnderer = GetComponent<SpriteRenderer>();
    }
    void Update(){
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        print(abs(angle));
        if(-90 => angle >= 90){
            rnderer.flipY = true;
        }else if(-90 <= angle <= 90){
            rnderer.flipY = false;
        }
    }
}
