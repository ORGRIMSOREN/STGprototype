using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameContorller : MonoBehaviour
{

    public GameObject gameOverText;
    public GameObject gameover;
    public Text scoreNO;
    
    int scores = 0;
    void Start()
    {
        gameOverText.SetActive(false);
        gameover.SetActive(false);
        AddScores();
    }

    public void AddScores()
    {
        scores += 100;
        scoreNO.text = "SCORE:" + scores;
    }
    //­«¨Ó
    public void GameOver()
    {
        gameOverText.SetActive(true);
        gameover.SetActive(true);
        Time.timeScale = 0f;

    }
    private void Update()
    {
        if (gameOverText.activeSelf==true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("main");
                Time.timeScale = 1f;
            }
        }
        
    }
   
}
