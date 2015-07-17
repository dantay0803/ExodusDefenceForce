using UnityEngine;
using System.Collections;

public class scr_pauseGame : MonoBehaviour {
    //DefineThePauseMenuObjects
    public GameObject obj_toggleMusicButton;
    public GameObject obj_toggleSFXButton;
    public GameObject obj_mainMenuButton;
    public GameObject obj_exitButton;
    public GameObject bg_pauseMenu;
    //DefineAudioClips
    //ButtonClick
    public AudioClip snd_buttonClick;

    // Use this for initialization
    void Start () {
        //SetTheGameAsRunning
        Time.timeScale = 1;
	}
	
	//PauseTheGame
    public void pauseGame(){
        //CheckIfGameIsRunning
        if(Time.timeScale == 1){
            //PauseGame
            Time.timeScale = 0;
            //DisplayPauseMenuObjects
            showPauseMenu();
        }
        //CheckIfGameIsPaused
        else if(Time.timeScale == 0){
            //RunGame
            Time.timeScale = 1;
            //HidePauseMenuObjects
            hidePauseMenu();
        }
        //Play the button click clip using the sound manager object
        scr_soundManager.instance.playSingle(snd_buttonClick);
    }


    //DisplayPauseMenu
    void showPauseMenu(){
        //DisplayPauseMenuBacking
        bg_pauseMenu.transform.position = new Vector2(0, 0);
        //DisplayPauseMenuButtons
        obj_toggleSFXButton.transform.position = new Vector2(Screen.width/2, Screen.height/2 + 120);
        obj_toggleMusicButton.transform.position = new Vector2(Screen.width / 2, Screen.height / 2 + 40);
        obj_mainMenuButton.transform.position = new Vector2(Screen.width/2, Screen.height/2 - 40);
        obj_exitButton.transform.position = new Vector2(Screen.width/2, Screen.height/2 - 120);
    }

    //HidePauseMenu
    void hidePauseMenu(){
        //HidePauseMenuBacking
        bg_pauseMenu.transform.position = new Vector2(-100, bg_pauseMenu.transform.position.y);
        //HidePauseMenuButtons
        obj_toggleSFXButton.transform.position = new Vector2(-1000, Screen.height / 2 + 120);
        obj_toggleMusicButton.transform.position = new Vector2(-1000, Screen.height / 2 + 40);
        obj_mainMenuButton.transform.position = new Vector2(-1000, Screen.height / 2 - 40);
        obj_exitButton.transform.position = new Vector2(-1000, Screen.height / 2 - 120);
    }
}
