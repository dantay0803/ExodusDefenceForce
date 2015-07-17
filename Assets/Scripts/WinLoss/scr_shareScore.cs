using UnityEngine;
using System.Collections;

public class scr_shareScore : MonoBehaviour {

    public AudioClip snd_buttonClick;

	//PostUserScoreToTwitter
    public void postToTwitter(){
        //Play the button click clip using the sound manager object
        scr_soundManager.instance.playSingle(snd_buttonClick);
        //Set the link to post on twitter
        string twitterAdress = "http://twitter.com/intent/tweet";
        //CheckIfThePlayerreachedBeatTheLastleve;
        if (Application.loadedLevelName == "scene_gameWin"){
            //IfTruePostToTwitterThatThePlayerBeatTheGame
            Application.OpenURL(twitterAdress + "?text=I just completed Exodus Defence Force from @BrainlessGames");
        }
        //CheckIfThePlayerLostTheGameToPostTheLevelThatTheyReached
        else if (Application.loadedLevelName == "scene_gameOver"){
            //HoldTheNameOfTheLevelReached
            string levelReached = "";
            PlayerPrefs.SetString("lastLevel", "Scene_LevelOne");
            //CheckTheSceneNameThatWasSavedToRepresentTheLastLevel
            switch (PlayerPrefs.GetString("lastLevel")){
                case "Scene_LevelOne":
                    levelReached = "level 1";
                    break;
                case "Scene_LevelTwo":
                    levelReached = "level 2";
                    break;
                case "Scene_LevelThree":
                    levelReached = "Level 3";
                    break;
                case "Scene_LevelFour":
                    levelReached = "Level 4";
                    break;
                case "Scene_LevelFive":
                    levelReached = "Level 5";
                    break;
                case "Scene_LevelSix":
                    levelReached = "Level 6";
                    break;
            }
            //PostTheNameOfTheLevelThePlayerMadeItToo
            Application.OpenURL(twitterAdress + "?text=" + "I made it to " + levelReached + " on Exodus Defence Force from @BrainlessGames");
        }
    }
}