using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xroom : MonoBehaviour
{
    public GameObject openBtn;
    public GameObject key;
    
    void Update()
    {
        if (key.activeSelf)
        {
            openBtn.SetActive(true);
        }
        else
        {
            openBtn.SetActive(false);
        }
    }
}
