using UnityEngine;
using System.Collections;

public class scr_moveCamera : MonoBehaviour {

    //Get mouse pressed position
    float mousePressedPosition = 0;
    float mouseReleasedPosition = 0;

    void OnMouseDown()
    {
        mousePressedPosition = Input.mousePosition.x;
    }

    void OnMouseUp()
    {
        mouseReleasedPosition = Input.mousePosition.x;
        moveCamera();
    }


    void moveCamera()
    {
        Vector3 camPos = Camera.main.transform.position;

        if(mousePressedPosition > mouseReleasedPosition){
            //Move camera to right grid
          
            camPos.x = 20.5f;
        }
        else if(mouseReleasedPosition > mousePressedPosition){
            //move camera to left grid
            camPos.x = 5.5f;
        }
        Camera.main.transform.position = camPos;
    }
}
