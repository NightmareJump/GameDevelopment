/*
 *  Yanyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack2 : MonoBehaviour
{
    public PlayerControl get; //set a variable get to get the variable from PlayerControl
    public float  dis2;  //set two variable to calculate the distance between enemy and player
    public Transform Target, Player;  // get the transform of player and target
    public Transform respawnPoint;   // set a respawn point transform
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Copper"); //create a gameobject 
        Player = go.transform;//set the player's transfrom as go's transfrom
    }

    // Update is called once per frame
    void Update()

    {

        GameObject Enemy2 = GameObject.Find("Enemy2");// create a variable for enmey 2
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // calculate the distance between player and enemy
            dis2 = Vector3.Distance(Player.position, Enemy2.transform.position); 
            if (dis2 <= 6) // if the distance between player and enemy less than 6
            {

                Destroy(gameObject); //destroy the gameobject
            }
        }

    }
    // to know whether has coolider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")// if the player has collider with the enemy
        {

            other.GetComponent<PlayerCharacter>().playerHealth -= 100;// reduce 100 health
            
        }
    }
}
