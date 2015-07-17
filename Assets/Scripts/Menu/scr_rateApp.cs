using UnityEngine;
using System.Collections;

public class scr_rateApp : MonoBehaviour {

    //OpenAnURLToAllowPlayersToRateTheGame
	public void rateApp(){
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Brainless+Games");
    }
}
