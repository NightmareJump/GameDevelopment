/*
 B00797115: Yanyue Meng
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingholder : MonoBehaviour
{
    // check whether palyer enter
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = gameObject.transform; //make the player position same as paltform
    }


    // check if the player leave
    private void OnTriggerExit(Collider other)
    {
        
        other.transform.parent = null; //set the player's parent to null
    }
}
