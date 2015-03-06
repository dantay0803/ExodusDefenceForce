using UnityEngine;
using System.Collections;

public class scr_selectBob : MonoBehaviour {

    public GameObject obj_levelOne;

    void OnMouseDown(){
        obj_levelOne.GetComponent<scr_placeTurrets>().turretSlected = true;
        obj_levelOne.GetComponent<scr_placeTurrets>().bobSelected = true;
    }
}
