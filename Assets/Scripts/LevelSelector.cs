using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelector : MonoBehaviour
{
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
