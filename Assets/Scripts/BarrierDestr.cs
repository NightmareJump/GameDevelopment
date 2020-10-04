/*
 Yanyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDestr : MonoBehaviour
{
    // colldier check
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //chcek whether has the collider with player
        {

            if(other.GetComponent<PlayerCharacter>().fuelCellNum == 3) //check the fuel cell if enough
            {
                Destroy(gameObject); // destroy the barrier
            }
            
        }
    }
}
