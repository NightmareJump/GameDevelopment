/*
 Yanyue Meng:B007997115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    //change to end scene
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //check if is player
        {

            SceneManager.LoadScene("Congratulation"); //change to end scene
        }
    }
}
