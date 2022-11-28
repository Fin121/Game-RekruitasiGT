using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void Play()
    {
        SceneManager.LoadScene("1-Roaming");
        Time.timeScale = 1f;
    }
}
