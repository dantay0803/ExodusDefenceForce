using UnityEngine;
using System.Collections;

public class scr_selectDefenceObject : MonoBehaviour {

    //OnClick/TouchPassTheNameOfTheCardToThePlaceDefenceObjectScriptToAllowThePlayerToSpawnDefenceObjects
	void OnMouseDown(){
        scr_placeDefenceObjects.instance.chooseDefenceObject(this.gameObject.name);
    }
}
