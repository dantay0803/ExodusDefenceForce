using UnityEngine;
using System.Collections;

public class scr_moveCameraHandler : MonoBehaviour {
    //Store the FIRST position of the mouse/screen touch to check for swipe in order to change camera
    float mousePressedPosition = 0;
    //Store the LAST position of the mouse/screen touch to check for swipe in order to change camera
    float mouseReleasedPosition = 690;
	
	// Update is called once per frame
	void Update () {
        //Check for mouse input for changing camera handler position
        getMouseInput();
	}


    //Check for mouse input for changing camera handler position
    void getMouseInput(){
        //Check for left mouse button click
        if (Input.GetMouseButtonDown(0)){
            //Get the current x position of the mouse
            mousePressedPosition = Input.mousePosition.x;
        }
        //Check for left mouse button released
        if (Input.GetMouseButtonUp(0)){
            //Get the position of the mouse after the user has swipped
            mouseReleasedPosition = Input.mousePosition.x;
            //Change object position depending on the different mouse start and end position values
            moveObjectAfterMouseSwipe();
        }    
    }

    //Change object position depending on the different mouse start and end position values
    void moveObjectAfterMouseSwipe(){
        //Get the current position of the camera and the camera handler
        Vector3 cameraHandlerPosition = transform.position;

        //Check if the mouse pressed position is less than the mouse released position to signal the user swipping their mouse/figer left to right to show the left grid
        if (mousePressedPosition < mouseReleasedPosition && (mouseReleasedPosition - mousePressedPosition > 450)){
            //Move the camera handler to the left grid at x 6.5
            cameraHandlerPosition.x = (float)6.5;
            Debug.Log(mouseReleasedPosition - mousePressedPosition);
        }
        else if (mousePressedPosition > mouseReleasedPosition && (mouseReleasedPosition - mousePressedPosition < 450))
        {
            //Move camera handler to the right gridat x 19.5
            cameraHandlerPosition.x = (float)19.5;
            Debug.Log(mouseReleasedPosition - mousePressedPosition);
        }
        //Update the camera handler position
        transform.position = cameraHandlerPosition;
    }
}
