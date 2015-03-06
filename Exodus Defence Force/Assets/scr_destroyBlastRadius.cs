using UnityEngine;
using System.Collections;

public class scr_destroyBlastRadius : MonoBehaviour {

    float timer = 0.5f;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
	    if(timer <= 0){
            Destroy(gameObject);
        }
	}
}
