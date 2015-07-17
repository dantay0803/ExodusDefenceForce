using UnityEngine;
using System.Collections;

public class scr_exit : MonoBehaviour {
    public AudioClip snd_buttonClick;
    
	//CloseTheApplication
	public void exitGame(){
        //CheckIfTheExitButtonIsClickedToCloseTheApplication
        if(this.gameObject.name == "obj_exitButton"){
            //CheckIfTheGameIsRunningOnAnIOSorAndroidDeviceToCloseTheGame
            if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android) {
                Application.Quit();
            }
            //CheckIfTheUserIsOnAWebBrowserToGoToTheMainMenuAsQuiteFeatureNotSupport
            else if(Application.platform == RuntimePlatform.WindowsWebPlayer || Application.platform == RuntimePlatform.OSXWebPlayer || Application.platform == RuntimePlatform.WebGLPlayer 
                || Application.platform == RuntimePlatform.WindowsEditor)
            {
                Application.LoadLevel("scene_mainMenu");
            }
        }
        //CheckIfTheMainMenuButtonIsClickedToGoToTheMainMenu
        else if(this.gameObject.name == "obj_mainMenuButton"){
            Application.LoadLevel("scene_mainMenu");
        }
        //Play the button click clip using the sound manager object
        scr_soundManager.instance.playSingle(snd_buttonClick);
    }
}
