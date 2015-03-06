using UnityEngine;
using System.Collections;

public class scr_setTurretImageDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    //Set the angle of the object
    void setDirection(){
        //Get the curret roation value
        Quaternion rot = transform.rotation;
        //imageAngle will be used to set the image angle by flipping the Y rotation
        float imageAngle = rot.eulerAngles.y;
        //Check what grid the object is on
        if (transform.position.x > 14)
        {
            //If the object is on the right grid keep the defualt image angle
            imageAngle = 0;
        }
        else
        {
            //If the object is on the left grid flip image angle
            imageAngle = 180;
        }
        //Set the rotation value
        rot = Quaternion.Euler(0, imageAngle, 0);
        //Update objects Y rotation value
        transform.rotation = rot;
    }
}
