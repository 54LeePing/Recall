using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pope : MonoBehaviour
{
    public Content content;
    public TextMeshProUGUI text;
    public GameObject portal;
    public GameObject wine;
    public GameObject key;
    
    void Start()
    {
        text.text = content.sentences[0];
    }

    public void Next()
    {
        if (wine.GetComponent<Image>().sprite.name == "WINE" && wine.activeSelf)
        {
            text.text = content.sentences[1];
            portal.SetActive(true);
        }
        else
        {
            text.text = content.sentences[2];
        }
    }

    public void Enter()
    {
        if (key.activeSelf)
        {
            SceneManager.LoadScene("xroom");
        }
        else
        {
            text.text = content.sentences[3];
        }
    }
}
