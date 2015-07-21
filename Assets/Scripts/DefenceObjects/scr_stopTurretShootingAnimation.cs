using UnityEngine;
using System.Collections;

public class scr_stopTurretShootingAnimation : MonoBehaviour {
    //CreateAnAnimatorToChangeTheObjectsAnimation
    Animator anim;

    public void stopShootingAnimation(){
        //GetTheAnimatorControllerComponentForTheObject
        anim = GetComponent<Animator>();
        //SetTheDefaultAnimationStateForTheTurret
        anim.SetInteger("turretState", 0);
    }
}
