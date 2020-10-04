/*
 Yanyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPick : MonoBehaviour
{

    //check the palyer get the fuel
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") // check if is player
        {
            
            other.GetComponent<PlayerCharacter>().fuelCellNum++; // increase the fuelcell number
            Destroy(gameObject); // destroy the fuel cell
       }
    }
}
