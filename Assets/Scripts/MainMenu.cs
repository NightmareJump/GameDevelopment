/*
 Yanyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // change the scene
    public  void playGame()
    {
        SceneManager.LoadScene("Scene1"); // change the scene to scene1
    }

    //quit the application
    public void QuitGame()
    {
        Application.Quit(); // quit the application
    }
}
