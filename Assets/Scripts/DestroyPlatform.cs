/*
 Yanyue Meng: B00797115
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    //check whether player come
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // if is player
        {
            Destroy(gameObject); //destroy the platform
        }
    }
}
