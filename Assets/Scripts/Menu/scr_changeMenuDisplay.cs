using UnityEngine;
using System.Collections;

public class scr_changeMenuDisplay : MonoBehaviour {
    //GetTheInstanceOfTheBackground
    public GameObject bg_mainMenu;
    //HoldTheCurrentPositionOfTheMenu
    Vector2 menuPos;
    //SetTheButtonObjectPresentInTheMainMenuScene
    public GameObject obj_startButton;
    public GameObject obj_toggleSFXButton;
    public GameObject obj_toggleMusicButton;
    public GameObject obj_rateButton;
    public GameObject obj_deleteSaveButton;

    //ChangeTheMenuDisplayWhenNavArrowClicked
    public void navArrowDown(){
        //GetTheCurrentPositionOfTheMenu
        menuPos = bg_mainMenu.transform.position;
        //CheckForRightArrowDown
        if (this.gameObject.name == "obj_rightArrow"){
            //CheckTheCurrentPositionOfTheMenuThenMoveItToTheRight
            if (menuPos.x == 14.5f){
                menuPos.x = -0.5f;
            }
            else if (menuPos.x == -0.5f){
                menuPos.x = -14;
            }
            else if (menuPos.x == -14){
                menuPos.x = 14.5f;
            }
        }
        //CheckForLeftArrowDown
        if (this.gameObject.name == "obj_leftArrow"){
            //CheckTheCurrentPositionOfTheMenuThenMoveItToTheRight
            if (menuPos.x == 14.5f){
                menuPos.x = -14;
            }
            else if (menuPos.x == -14){
                menuPos.x = -0.5f;
            }
            else if (menuPos.x == -0.5f){
                menuPos.x = 14.5f;
            }
        }
        bg_mainMenu.transform.position = menuPos;
        //SetThePositioningOfTheMenuObjects
        positionStartObjects();
        positionSettingsObjects();
    }

    //UpdateThePositionOfTheObjectsOnTheStartSectionOfTheMenu
    void positionStartObjects(){
        //CheckIfTheCameraIsDisplayingTheStartSectionOfTheMenu
        if(menuPos.x == 14.5f){
            //IfTrueDisplayStartButton
            obj_startButton.transform.position = new Vector2(Screen.width/2, Screen.height/2);
        }
        else{
            //IfNotHideStartButton
            obj_startButton.transform.position = new Vector2(-1000, 0);
        }
    }

    //UpdateThePositionOfTheObjectsOnTheSettingsSectionOfTheMenu
    void positionSettingsObjects()
    {
        //CheckIfTheCameraIsDisplayingTheSettingsSectionOfTheMenu
        if (menuPos.x == -0.5f){
            //IfTrueDisplaySettingsButtons
            obj_toggleSFXButton.transform.position = new Vector2(Screen.width/2, Screen.height/2+70);
            obj_toggleMusicButton.transform.position = new Vector2(Screen.width/2, Screen.height/2-10);
            obj_rateButton.transform.position = new Vector2(Screen.width/2, Screen.height/2-90);
            obj_deleteSaveButton.transform.position = new Vector2(Screen.width/2, Screen.height/2-170);
        }
        else{
            //IfNotHideSettingsButtons
            obj_toggleSFXButton.transform.position = new Vector2(-1000, this.transform.position.y);
            obj_toggleMusicButton.transform.position = new Vector2(-1000, this.transform.position.y);
            obj_rateButton.transform.position = new Vector2(-1000, -90);
            obj_deleteSaveButton.transform.position = new Vector2(-1000, this.transform.position.y);
        }
    }
}
