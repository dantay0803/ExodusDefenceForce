using UnityEngine;
using System.Collections;

public class scr_setEnemyImageDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Set the image direction of the object
        setDirection();

	}

    void setDirection(){
        //Get the curret roation value
        Quaternion rot = this.transform.rotation;
        //imageAngle will be used to set the image angle by flipping the Y rotation
        float imageAngle = rot.eulerAngles.y;
        //Check what grid the object is on
        if (this.transform.position.x > 14){
            //If the object is on the right grid flip the image
            imageAngle = 180;
        }
        else{
            //If the object is on the left grid keep defualt image angle
            imageAngle = 0;
        }
        //Set the rotation value
        rot = Quaternion.Euler(0, imageAngle, 0);
        //Update objects Y rotation value
        this.transform.rotation = rot;
    }
}
