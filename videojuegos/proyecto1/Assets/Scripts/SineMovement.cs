using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : MonoBehaviour
{
    [SerializeField] float amplitude;
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    float angle;
    Vector3 origin;

    void Start(){
        origin = transform.position;
    }

    void Update(){
        transform.position = origin + direction * Mathf.Sin(angle) * amplitude;
        angle += speed* Time.deltaTime;
    }
}
