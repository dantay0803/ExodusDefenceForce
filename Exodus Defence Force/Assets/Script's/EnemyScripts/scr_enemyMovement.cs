using UnityEngine;
using System.Collections;

public class scr_enemyMovement : MonoBehaviour {
    /* If you make a variable in a script public you can only set the variabels value in the inspector in unity, chnaging the value in the script will
     only chance its defualt value i.e. the value that will be used to affect the object if you were to drag the script on to the object*/
    public float movementSpeed;

    //Store enemy object that exists
    GameObject targetObject = null;
	
	// Update is called once per frame
	void Update () {

        gridPlaceEmpty();

	}

    //Function to move objects across the level
    void moveObject(){
        //Use a new Vector to get the objects current position to be able to change the position of the object
        Vector3 objectPosition = this.transform.position;
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
        this.transform.position = objectPosition;
    }

    //Check space in front of enemy on left grid has not turrets on it
    void gridPlaceEmpty()
    {
        //Find what player object exists in the scene and is on the same Y position
        if (GameObject.Find("obj_aob(Clone)") != null && GameObject.Find("obj_aob(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_aob(Clone)");
        }
        if (GameObject.Find("obj_bob(Clone)") != null && GameObject.Find("obj_bob(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_bob(Clone)");
        }
        if (GameObject.Find("obj_buzz(Clone)") != null && GameObject.Find("obj_buzz(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_buzz(Clone)");
        }
        if (GameObject.Find("obj_drill(Clone)") != null && GameObject.Find("obj_drill(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_drill(Clone)");
        }
        if (GameObject.Find("obj_fatMan(Clone)") != null && GameObject.Find("obj_fatMan(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_fatMan(Clone)");
        }
        if (GameObject.Find("obj_lnl(Clone)") != null && GameObject.Find("obj_lnl(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_lnl(Clone)");
        }
        if (GameObject.Find("obj_loadLifter(Clone)") != null && GameObject.Find("obj_loadLifter(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_loadLifter(Clone)");
        }
        if (GameObject.Find("obj_mk48(Clone)") != null && GameObject.Find("obj_mk48(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_mk48(Clone)");
        }
        if (GameObject.Find("obj_neon(Clone)") != null && GameObject.Find("obj_neon(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_neon(Clone)");
        }
        if (GameObject.Find("obj_ray(Clone)") != null && GameObject.Find("obj_ray(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_ray(Clone)");
        }
        if (GameObject.Find("obj_scatterBox(Clone)") != null && GameObject.Find("obj_scatterBox(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_scatterBox(Clone)");
        }
        if (GameObject.Find("obj_teslaCoil(Clone)") != null && GameObject.Find("obj_teslaCoil(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_teslaCoil(Clone)");
        }
        if (GameObject.Find("obj_toasty(Clone)") != null && GameObject.Find("obj_toasty(Clone)").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_toasty(Clone)");
        }

        //Check if target object is not found
        if (targetObject != null)
        {
            //If target object is found check if the target objetc is more than one grid space infront of the enemy on the left grid
           if (this.transform.position.x < 13 && targetObject.transform.position.x >= this.transform.position.x + 1)
            {
                //If this is true move the enemy
                moveObject();
            }
           //If target object is found check if the target objetc is more than one grid space infront of the enemy on the right grid
           else if (this.transform.position.x > 13 && targetObject.transform.position.x <= this.transform.position.x - 1){
               //If this is true move the enemy
               moveObject();
           }
        }
        //If no target object found move enemy no matter what
        else
        {
            moveObject();
        }
    }





}
