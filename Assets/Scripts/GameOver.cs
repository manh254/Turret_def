using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    // public void Retry(string levelName)
    // {
    //     SceneManager.LoadScene(levelName);
    //     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    // }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
