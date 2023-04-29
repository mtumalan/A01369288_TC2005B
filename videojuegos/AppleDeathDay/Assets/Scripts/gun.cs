using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform disparo;
    public float fireForce = 20f;

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, disparo.position, disparo.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(disparo.up * fireForce, ForceMode2D.Impulse);
    }

    void Update(){
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rot;
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }
}