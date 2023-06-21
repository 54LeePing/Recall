using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 180f;
    private float totalTime;
    public GameObject hp;
    
    

    private void Awake()
    {
        int singletonNum = FindObjectsOfType<GameManager>().Length;
        if (singletonNum > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        Lib.hasRead = false;
        
        totalTime = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            hp.GetComponent<Image>().fillAmount = timer / totalTime;
        }
        else if (timer <= 0)
        {
            SceneManager.LoadScene(1);
        }

        if (SceneManager.GetActiveScene().name == "Start")
        {
            Destroy(gameObject);
        }
    }
    
}
