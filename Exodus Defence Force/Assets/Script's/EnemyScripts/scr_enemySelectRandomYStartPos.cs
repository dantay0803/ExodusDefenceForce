using UnityEngine;
using System.Collections;

public class scr_enemySelectRandomYStartPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Choose random X starting position for object
        chooseRandomXStart();

        //Choose random Y starting position for object
        chooseRandomYStart();
	}

    //Choose random X starting position for object
    void chooseRandomXStart(){
        //Hold a random value to determin objects random X position
        int xPos = Random.Range(0, 2);
        //Use a new Vector to get the objects current position to be able to change the position of the object
        Vector3 objectPosition = this.transform.position;
        //ChooseRandomXStartPos
        switch (xPos){
            //Place the object on the left grid
            case 0:
                objectPosition.x = -2.5f;
                break;
            //Place the object on the right grid
            case 1:
                objectPosition.x = 28.5f;
                break;
            default:
                objectPosition.x = -2.5f;
                break;
        }
        //Update the objects position by setting it to the randomly generated positions
        transform.position = objectPosition;	
    }

    //Choose random Y starting position for object
    void chooseRandomYStart(){
        //Hold a random value to determin objects random Y position
        int yPos = Random.Range(0, 5);
        //Use a new Vector to get the objects current position to be able to change the position of the object
        Vector3 objectPosition = this.transform.position;
        //ChooseRandomYStartPos
        switch (yPos){
            //Y=352
            case 0:
                objectPosition.y = (float)-5.5;
                break;
            //Y=416
            case 1:
                objectPosition.y = (float)-6.5;
                break;
            //Y=480
            case 2:
                objectPosition.y = (float)-7.5;
                break;
            //Y=544
            case 3:
                objectPosition.y = (float)-8.5;
                break;
            //Y=608
            case 4:
                objectPosition.y = (float)-9.5;
                break;
            //DefualtCase
            default:
                objectPosition.y = (float)-7.5;
                break;
        }
        //Update the objects position by setting it to the randomly generated positions
        this.transform.position = objectPosition;    
    }
}
