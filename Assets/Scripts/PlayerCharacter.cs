/*
 Yanyue Meng:B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{   
    //set the player's health
    public int playerHealth;
    // set tthe  fuel cell's number
    public int fuelCellNum;
    // get the transform of carmera and player
    public Transform Target, Player;
    // set the resoawnpoint
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        //initial the player health to 100
        playerHealth = 100;
        //intitial the fuel cell to 0
        fuelCellNum = 0;
        // find the player gameobject
        GameObject go = GameObject.Find("Copper");

        // set the copper to target
        Target = go.transform;
        // set the copper to player
        Player = go.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth == 0) //judge whether the health equal to 0
        {
            Player.transform.position = respawnPoint.position; // reswoan the palyer
            playerHealth = 100; //give 100 health
        }
    }
}
