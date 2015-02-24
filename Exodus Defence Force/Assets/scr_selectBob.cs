using UnityEngine;
using System.Collections;

public class scr_selectBob : MonoBehaviour {

    public GameObject obj_cameraHandler;

    void OnMouseDown()
    {
        obj_cameraHandler.GetComponent<scr_placeTurrets>().turretSlected = true;
        obj_cameraHandler.GetComponent<scr_placeTurrets>().bobSelected = true;
    }
}
