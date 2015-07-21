using UnityEngine;
using System.Collections;

public class scr_setExplosionAnimation : MonoBehaviour {
    //GetTheAnimatorComponenet
    Animator anim;

	// Use this for initialization
	void Start() {
        //GetTheAnimatorAndPlayTheAnimation
        anim = this.GetComponent<Animator>();
        anim.SetInteger("turretState", 2);
	}
	
}
