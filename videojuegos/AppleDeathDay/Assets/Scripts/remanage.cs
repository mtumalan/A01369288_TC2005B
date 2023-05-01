//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class remanage : MonoBehaviour
{
    public TextMeshProUGUI restart;
    public GameObject sc;
    void Start()
    {
        restart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Restart();
    }

    void Restart()
    {
        if(health.health_ <= 0)
        {
            restart.gameObject.SetActive(true);
            if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score_.scoreValue = 0;
            }   
        }
        
    }
}
