using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scr_displayScore : MonoBehaviour {

    //SetIfTheCameraMoveScriptExists
    public static scr_displayScore instance = null;

    Text text;

    //Use for initialize
    void Awake(){
        instance = this;
        //GetTheTextComponentOfTheUITextObjects
        text = GetComponent<Text>();
    }

    //DisplayTheAmountOfPointsTheUserHasInOrderToCreateDefenceObjects
    public void displayOil(int oil) {
        text.text = "oil: " + oil.ToString(); 
	}

    //UpdateThePositionOfTheTextDisplayBasedOnTheCameraPosition
    public void moveScoreDisplay(){
        //IfTheScoreDisplayIsOnTheLeftGridMoveItToTheRightGridDisplayPosition
        if(this.transform.position.x == Screen.width / 2 + 470){
            this.transform.position = new Vector3(Screen.width/2 - 430, this.transform.position.y, this.transform.position.z);
        }
        //IfTheScoreDisplayIsOnTheRightGridMoveItToTheLeftGridDisplayPosition
        else if (this.transform.position.x == Screen.width / 2 - 430){
            this.transform.position = new Vector3(Screen.width / 2 + 470, this.transform.position.y, this.transform.position.z);
        }
    }
}
