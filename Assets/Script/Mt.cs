using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Mt : MonoBehaviour
{
    public Content content;
    public TextMeshProUGUI text;
    public GameObject portal;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Lib.hasRead)
        {
            text.text = content.sentences[1];
        }
        else
        {
            text.text = content.sentences[0];
        }
    }

    public void Next()
    {
        portal.SetActive(true);
        if (Lib.hasRead)
        {
            portal.transform.Find("ruin").gameObject.SetActive(true);
        }
        else
        {
            portal.transform.Find("ruin").gameObject.SetActive(false);
        }
    }
    
    public void SwitchPlace(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
