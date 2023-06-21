using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    public Content content; // scriptable object
    public Content itemContent;
    public TextMeshProUGUI text;
    private int order = 0;
    public GameObject portal;

    private void Start()
    {
        text.text = content.sentences[order];
    }

    public void Next()
    {
        if (order < content.sentences.Count - 1)
        {
            order++;
            text.text = content.sentences[order];
        }
        else if (order == content.sentences.Count - 1)
        {
            portal.SetActive(true);
        }
    }

    public void SwitchPlace(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ItemOnClick(int idx)
    {
        text.text = itemContent.sentences[idx];
    }
}
