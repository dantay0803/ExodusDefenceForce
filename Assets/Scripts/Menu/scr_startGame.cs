using UnityEngine;
using System.Collections;

public class scr_startGame : MonoBehaviour {

	public void startGame()
    {
        Application.LoadLevel("scene_defenceSelection");
    }
}
