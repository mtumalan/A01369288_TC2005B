using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_rotation : MonoBehaviour
{
    public Transform player;
    private SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        if (_renderer == null)
        {
            Debug.LogError("Player Sprite is missing a renderer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (angle < 90)
        {
            _renderer.flipY = true;
        }
        else if (angle > 90)
        {
            _renderer.flipY = false;
        }  
    }
}
