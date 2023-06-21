using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public GameObject menuPanel;
    public string backPlace;
    
    public void Back()
    {
        SceneManager.LoadScene(backPlace);
    }

    public void Menu()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
