using UnityEngine;
using System.Collections;

public class scr_checkForSwipe : MonoBehaviour {
    //HoldThePositionOfWhenTheMouse/ScreenIsPressedAndReleased
    float touchStart, touchEnd;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            touchStart = Input.mousePosition.x;
        }
        if(Input.GetMouseButtonUp(0)){
            touchEnd = Input.mousePosition.x;
            //MoveTheCamera
            moveCamera();
        }
    }

    //CheckForUserSwipeAndMovecamera
    void moveCamera(){
        //CheckForPlayerSwipingFromRightToLeftToMoveCameraToShowRightHandGrid
        if (touchStart > touchEnd && (touchStart - touchEnd) > 300 && Camera.main.transform.position.x != 14){
            //RunMoveCameraRightFunction
            scr_moveCamera.instance.showRightGrid();
            scr_displayScore.instance.moveScoreDisplay();

        }
        //CheckForPlayerSwipingFromLeftToRightToMoveCameraToShowLeftHandGrid
        else if (touchEnd > touchStart && (touchEnd - touchStart) > 300 && Camera.main.transform.position.x != 0){
            //RunMoveCameraLeftScript
            scr_moveCamera.instance.showLeftGrid();
            //UpdateScoreDisplayPosition
            scr_displayScore.instance.moveScoreDisplay();
        }
    }
}
