using UnityEngine;
using System.Collections;

public class scr_checkObjectsHealth : MonoBehaviour {
    //GetTheObjectsHealth
    public float objectHealth;


	
	// Update is called once per frame
	void Update () {

        //Check if health is less than or equal to 0
        if(objectHealth<=0){
            //If true remove the instance of the object
            Destroy(gameObject);
        }
	}
}
