/*
  Yanyue Meng : B00797115
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform moving; //get a transform of object
    public Transform position1; // seet the first position in moving
    public Transform position2; //set the seconde position in moving

    public Vector3 newPosition; // set a newposiotn
    public string currentState; // set the current state

    public float smooth;  // set the smooth of the moving
    public float resetTime; //get a reset time

    // Start is called before the first frame update
    void Start()
    {
        changeTarget(); //recall the changetarget funciton
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moving.position = Vector3.Lerp(moving.position, newPosition, smooth * Time.deltaTime); //make the platform moving
    }


    // this function is to check which postion the platform is in and change its posyion

    void changeTarget()
    {
        if (currentState == "Moving to Position 2") //check the state
        {
            currentState = "Moving to Position 1"; // set tthe state to another one
            newPosition = position2.position; // change to another position
        }
        else if (currentState == "Moving to Position 1")//check the state
        {
            currentState = "Moving to Position 2";// set tthe state to another one
            newPosition = position1.position;// change to another position
        }
        else if (currentState == "")//check the state
        {
            currentState = "Moving to Position 2";// set tthe state to another one
            newPosition = position1.position;// change to another position
        }
        Invoke("changeTarget", resetTime);
    }

}
