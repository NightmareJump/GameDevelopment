/*
 *  Yanyue Meng: B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //set a variable get to get the variable from PlayerControl
    public PlayerControl get;
    //set two variable to calculate the distance between enemy and player
    public float dis1, dis2;
    // get the transform of player and target
    public Transform Target, Player;
    // set a respawn point transform
    public Transform respawnPoint;
    // set an animation variable
    public Animation run;
    // Start is called before the first frame update
    void Start()
    {
        //create a gameobject 
        GameObject go = GameObject.Find("Copper");
        //set the player's transfrom as go's transfrom
        Player = go.transform;
        //let run get the animation compomemt
        run = go.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
       
    {
        // create a variable for enmey 1
        GameObject Enemy1 = GameObject.Find("Enemy1");
        // calculate the distance between player and enemy
        dis1 = Vector3.Distance(Player.position, Enemy1.transform.position);

        // left mouse click event
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {


            if (dis1 <= 6) // if the distance between player and enemy less than 6
            {

                Destroy(gameObject); //destroy the gameobject
            }
        }

    }

    // to know whether has coolider
    void OnTriggerEnter(Collider other)
    {
        // if the player has collider with the enemy
        if (other.gameObject.tag == "Player")
        {

            other.GetComponent<PlayerCharacter>().playerHealth -=100 ; // reduce 100 health
            // play the gohit animation
            run.Play("gothit");
        }
    }
}
