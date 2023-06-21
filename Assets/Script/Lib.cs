using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lib : MonoBehaviour
{
    private GameObject bookA;
    public static bool hasRead;
    
    // Start is called before the first frame update
    void Start()
    {
        hasRead = false;

        bookA = GameObject.FindWithTag("A");
        if (bookA == null)
        {
            Debug.Log("無法找到具有標籤的物件");
        }
        bookA.GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        hasRead = true;
    }
}
