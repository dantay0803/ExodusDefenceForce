using UnityEngine;
using System.Collections;

public class scr_moveCamera : MonoBehaviour{

    //Set what object the camera will follow
    public Transform myTarget;

    // Update is called once per frame
    void Update(){
        //Move camera to same position as camera handler
        moveCamera();
    }

    //Move camera to same position as camera handler
    void moveCamera(){
        //Check to make sure myTarget has been given an object value for the camera to follow
        if (myTarget != null){
            //Create a new vector in order to update camera position
            Vector3 targPos = myTarget.position;

            /*Set the target Z position of the camera to the cameras current Z position to stop it
            from matching the object you want to follows Z position which will stop you from seeing any objects on screen potentially*/
            targPos.z = transform.position.z;

            //Set the cameras X and Y values to match the object you are following X and Y values
            transform.position = targPos;
        }
    }
}