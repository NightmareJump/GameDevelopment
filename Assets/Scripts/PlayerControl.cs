/****************************************************************************************
 
 B00797115:Yanyue Meng

 ****************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //define the speed of character
    public float speed = 3.0f;
    //define the rotation speed of character
    public float rotationSpeed = 1.0f;
    // define two variable of Camera and Player
    public Transform Target, Player;

    // define two varibale of mouse
    float mouseX, mouseY;
    //define a rigidbody
    public Rigidbody rb;
    // define a layermask
    public LayerMask groundLayers;
    // define the jumo force
    public float jumpForce = 7;
    //define a boxcollider
    public BoxCollider box;
    // define a animation variable
    public Animation run;
    // define a respawnPoint's transform
    public Transform respawnPoint;
    //define whether enmey
    public int IsEnemy;
    //define two distance
    public float dis1, dis2;
    // Start is called before the first frame update
    void Start()
    {
        // get the component rigidbody
        rb = GetComponent<Rigidbody>();
        //set the cursor invisible
        Cursor.visible = false;
        // set the cursor state to be locked
        Cursor.lockState = CursorLockMode.Locked;
        //find the gameobject copper
        GameObject go = GameObject.Find("Copper");

        // set the copper to target
        Target = go.transform;
        // set the copper to player
        Player = go.transform;
        //set a box collider
        box = GetComponent<BoxCollider>();
        // get a variable for the animation
        run = go.GetComponent<Animation>();


    }

    // Update is called once per frame
    void Update()
    {
        //get the gameobject enemy1
        GameObject Enemy1 = GameObject.Find("Enemy1");
        //get the enmey2 
        GameObject Enemy2 = GameObject.Find("Enemy2");
        // use the playermovement method
        PlayerMovement();
        // recall the camcontrol method
        CamControl();

        // spacekey event
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //add jump force
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // play turnjump animation
            run.Play("turnjump");
        }

        // leftshit event
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10; //set the speed to 10
        }
        // lefshift event
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 3; // set the speed to 3
        }
        //ResetPosition();

        // judge whether the tranform of the player lower than the game
        if(Player.transform.position.y <= -20)
        {
            Player.transform.position = respawnPoint.position; // set the player to respawn point
        }

        // left mouse event
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
            run.Play("attackrun"); // play the attack run animation

        }
    }

    /************************************************************************************
     * 
     * This method is to control the player's movement
     * 
     * *********************************************************************************/
    void PlayerMovement()
    {   
        //get the horizontal axis 
        float h = Input.GetAxis("Horizontal");

        //get the vertical axis
        float v = Input.GetAxis("Vertical");
        
        // set a vertor for the playmove and mutiple with speed and time

        Vector3 playerMovement = new Vector3(h, 0, v) * speed * Time.deltaTime;

        rb.AddForce(playerMovement);
        //use the translate make the player move
        transform.Translate(playerMovement, Space.Self);
 
    }

 /************************************************************************************
 * 
 * This method is to control the player's and camera's rotation 
 * 
 * *********************************************************************************/
    void CamControl()
    {
        //setthe mousex plus with the mouse to left
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        //set the mousey plus with the mouse move to right
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        //set the mousey use mathf
        mouseY = Mathf.Clamp(mouseY, -35, 60);
        // make look at the target
        transform.LookAt(Target);
        //set the camera rotation
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        //set the player's rotation
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }

}
