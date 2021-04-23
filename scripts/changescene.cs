using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{

    public void LaunchGame(){
        SceneManager.LoadScene("Game");
    }
    public void LaunchHelp(){
        SceneManager.LoadScene("Help");
    }
    public void QuitApp(){
        Application.Quit();
    }
     public void Back(){
        SceneManager.LoadScene("UI");
    }
}