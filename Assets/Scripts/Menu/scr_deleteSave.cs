using UnityEngine;
using System.Collections;

public class scr_deleteSave : MonoBehaviour {
    //AllowTheUserToDeleteTheirSave
	public void deleteSave(){
        PlayerPrefs.SetInt("SavedLevel", 0);
    }
}
