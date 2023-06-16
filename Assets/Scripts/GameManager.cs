using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioManager audio;
    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject winGameUI;

    // Start is called before the first frame update
    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameIsOver)
        {
            return;
        }
        
        if(PlayerStats.Lives <= 0)
        {
            EndGame();
            
        }


    }

    public void EndGame()
    {
        audio.LoseSound();
        GameIsOver = true;
        gameOverUI.SetActive(true);
        this.enabled = false;
    }

    public void WinGame()
    {
        audio.WinSound();
        GameIsOver = true;
        winGameUI.SetActive(true);
        //Debug.Log("Win");

    }
}
