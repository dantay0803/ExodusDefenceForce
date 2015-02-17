using UnityEngine;
using System.Collections;

public class scr_enemyMovement : MonoBehaviour {
    /* If you make a variable in a script public you can only set the variabels value in the inspector in unity, chnaging the value in the script will
     only chance its defualt value i.e. the value that will be used to affect the object if you were to drag the script on to the object*/
    public float movementSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //MoveObject
        moveObject();
	}

    //Function to move objects across the level
    void moveObject(){
        //Use a new Vector to get the objects current position to be able to change the position of the object
        Vector3 objectPosition = transform.position;
        //Check if the object is on the left grid
        if (objectPosition.x < 13){
            //If it ias add the movementSpeed to the objects current x position
            objectPosition.x += movementSpeed * Time.deltaTime;
        }
        else{
            //If it is not on the left grid take the movementSpeed away from its position
            objectPosition.x -= movementSpeed * Time.deltaTime;
        }
        //Update the objects position by setting it to the same value as objectPosition
        transform.position = objectPosition;
    }
}
