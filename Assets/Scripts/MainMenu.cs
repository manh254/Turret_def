using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject sound;
    public GameObject settingUI;
    public GameObject mainMenuUI;
    public void Play()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void Setting()
    {
        settingUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void Back()
    {
        settingUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void OnSound()
    {
        sound.SetActive(true);
    }

    public void OffSound()
    {
        sound.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
