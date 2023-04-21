using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HorizontalMovement : MonoBehaviour
{
    Vector3 move;
    public float speed;
    public float limit;
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        if(transform.position.x < -limit && move.x < 0){
            move.x=0;
        }else{
            move.x=0;
        }

        transform.Translate(move * speed * Time.deltaTime);

    }
}
