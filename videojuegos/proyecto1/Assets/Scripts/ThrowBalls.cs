/* 
Crea copias del objeto de la pelota cayendo en escena
MT
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBalls : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] GameObject ball;
    [SerializeField] float limit;

    void Start()
    {
        InvokeRepeating("CreateBall",delay,delay); //Repite constantemente
    }

    void CreateBall(){
        Vector3 newPos = new Vector3(Random.Range(-limit, limit), 7, 0);
        Instantiate(ball, newPos, Quaternion.identity);
    }
}
