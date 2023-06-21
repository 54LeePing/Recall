using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject slots;
    public GameObject coin;
    private bool hasCoin;
    public GameObject target;
    public List<Sprite> products;

    private void Update()
    {
        hasCoin = coin.activeSelf;
    }

    public void Buy(int idx)
    {
        if (hasCoin)
        {
            coin.SetActive(false);
            target.SetActive(true);
            target.GetComponent<Image>().sprite = products[idx];
            
            slots.SetActive(false);
        }
    }
}
