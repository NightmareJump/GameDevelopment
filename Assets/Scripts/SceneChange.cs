/*
 YAnyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // judge the collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // if the player trigger
        {
            //load to scene2
            SceneManager.LoadScene("Scene2");
        }
    }
}
