using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] Vector2 speed = new Vector2(50,50);

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        move *= Time.deltaTime;

        transform.Translate(move);
    }
}
