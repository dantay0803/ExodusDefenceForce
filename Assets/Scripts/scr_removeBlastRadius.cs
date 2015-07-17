using UnityEngine;
using System.Collections;

public class scr_removeBlastRadius : MonoBehaviour {
	
    //SetATimerToRemoveTheBlastRadius
    float timer = 1;

	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0){
            Destroy(this.gameObject);
        }
	}
}
