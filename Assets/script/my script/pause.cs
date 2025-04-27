using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject pausemenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                resume();
            }
            else
            {
                pausegame();
            }
        }
    }

    public void    resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    public void    pausegame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void loadmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
