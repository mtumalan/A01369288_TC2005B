using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dr_spawn : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] GameObject enemy;
    [SerializeField] float limit_x;
    [SerializeField] float limit_y;
    void Start()
    {
        InvokeRepeating("CreateEnemies",delay,delay);
    }

    void CreateEnemies()
    {
        Vector3 newPos1 = new Vector3(Random.Range(-limit_x, limit_x), -limit_y, 1);
        Vector3 newPos2 = new Vector3(Random.Range(-limit_x, limit_x), limit_y, 1);
        Vector3 newPos3 = new Vector3(limit_x, Random.Range(-limit_y, limit_y), 1);
        Vector3 newPos4 = new Vector3(-limit_x, Random.Range(-limit_y, limit_y), 1);
        Instantiate(enemy, newPos1, Quaternion.identity);
        Instantiate(enemy, newPos2, Quaternion.identity);
        Instantiate(enemy, newPos3, Quaternion.identity);
        Instantiate(enemy, newPos4, Quaternion.identity);
    }
}
