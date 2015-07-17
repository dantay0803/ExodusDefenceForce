using UnityEngine;
using System.Collections;

public class scr_turretDamage : MonoBehaviour {
    //SetObjectsHealth
    public int defenceObjectsHealth;
    //HoldTheNameOfTheEnemyObjectInfrontOfTheTurret
    string enemyObjectName;
    //TrackifThisIsTheFirstTimeTheGameHasBeenRunInOrdertoStopDamageBeingAddedToTheTurretAtTheStartOfTheGame
    bool firstRun = true;
    //DefineDamageValueAndHowQuicklyTheDamageShouldBeApplied
    int fireSpritterDamageTimer = 3, fireSpritterDamage = 10;
    int gathererDamageTimer = 1, gathererDamage = 10;
    int hunterDamageTimer = 1, hunterDamage = 40;
    int reinforcedWorkerDamageTimer = 1, reinfrocedWorkerDamage = 20;
    int rockyDamageTimer = 1, rockyDamage = 50;
    int wheelWorkerDamageTimer = 1, wheelWorkerDamage = 20;
    int workerDamageTimer = 1, workerDamage = 20;
    int zapperDamageTimer = 6, zapperDamage = 20;
    //KeepTrackOfTheCurrentCountDown
    float damageCountDownTimer = 0;
    //HoldTheDamageOfTheEnemyInfrontOfTheTurret
    int selectedEnemyDamage = 0;
    //KeepTrackOfTheDamageSpeedOfTheEnemyInfrontOfTheTurret
    int selectedEnemyTimer = 0;

    void Start(){
        flipImage();
    }

    // Update is called once per frame
    void Update () {
        //CheckIfAnyEnemyObjectsAreInfrontOfTheTurret
        checkForCollision();
    }

    //FlipTheImageIfItSpawnsOnTheLeftGrid
    void flipImage()
    {
        if (this.transform.position.x < 7)
        {
            //GetTheCurretRotationvaluesOfTheObject
            Vector3 imageScale = transform.localScale;
            //FlipTheImageOnItsYAxis
            imageScale.x *= -1;
            //UpdateImageRotation
            transform.localScale = imageScale;
        }
    }

    //CheckIfAnyEnemyObjectsAreInfrontOfTheTurret
    void checkForCollision(){
        //GetTheObjectsCurrentPosition
        Vector2 objectPos = this.transform.position, rightRadius = this.transform.position, leftRadius = this.transform.position;
        //SetTheDistanceTheRaycastShouldCheckWhenMovingRight
        rightRadius.x += 0.5f;
        //SetTheDistanceTheRaycastShouldCheckWhenMovingLeft
        leftRadius.x -= 0.5f;
        //CreateRayCastsToChechForCollisions
        RaycastHit2D leftHit = Physics2D.Linecast(objectPos, leftRadius, 1 << LayerMask.NameToLayer("enemyObjects"));
        RaycastHit2D rightHit = Physics2D.Linecast(objectPos, rightRadius, 1 << LayerMask.NameToLayer("enemyObjects"));
        //DefenceObjectOnLeftGrid
        if (this.transform.position.x < 7){
            //CheckForEnemyObjectInFrontOfDefence
            if(leftHit){
                //IfACollisionIsDetecedSaveTheObjectsNameInOrderToApplyDamageToTheTurrets
                enemyObjectName = leftHit.collider.name;
                //ApplyDamageToTurretsWhenCollisionIsDetected
                applyDamage();
            }
            //IfNoCollisionResetDamageTimer
            else{
                damageCountDownTimer = 0;
            }
        }
        //DefenceObjectOnRightGrid
        else if(this.transform.position.x > 7){
            //CheckForEnemyObjectInFrontOfDefence
            if(rightHit){
                //IfACollisionIsDetecedSaveTheObjectsNameInOrderToApplyDamageToTheTurrets
                enemyObjectName = rightHit.collider.name;
                //ApplyDamageToTurretsWhenCollisionIsDetected
                applyDamage();
            }
            //IfNoCollisionResetDamageTimer
            else{
                damageCountDownTimer = 0;
            }
        }
    }

    //ApplyDamageToTheTurretsWhenACollisionIsDetected
    void applyDamage(){
        //CheckTheNameOfTheEnemyInFrontOfTheTurretAndApplyItsDamageAndDamageRateToTheTimerAndDamageVariables
        switch (enemyObjectName){
            case "obj_fireSpitter(Clone)":
                selectedEnemyTimer = fireSpritterDamageTimer;
                selectedEnemyDamage = fireSpritterDamage;
                break;
            case "obj_gatherer(Clone)":
                selectedEnemyTimer = gathererDamageTimer;
                selectedEnemyDamage = gathererDamage;
                break;
            case "obj_hunter(Clone)":
                selectedEnemyTimer = hunterDamageTimer;
                selectedEnemyDamage = hunterDamage;
                break;
            case "obj_reinforcedWorker(Clone)":
                selectedEnemyTimer = reinforcedWorkerDamageTimer;
                selectedEnemyDamage = reinfrocedWorkerDamage;
                break;
            case "obj_rocky(Clone)":
                selectedEnemyTimer = rockyDamageTimer;
                selectedEnemyDamage = rockyDamage;
                break;
            case "obj_wheelWorker(Clone)":
                selectedEnemyTimer = wheelWorkerDamageTimer;
                selectedEnemyDamage = wheelWorkerDamage;
                break;
            case "obj_worker(Clone)":
                selectedEnemyTimer = workerDamageTimer;
                selectedEnemyDamage = workerDamage;
                break;
            case "obj_zapper(Clone)":
                selectedEnemyTimer = zapperDamageTimer;
                selectedEnemyDamage = zapperDamage;
                break;
        }
        //CheckIfTheDamageTimerHasFinished
        if(damageCountDownTimer <= 0){
            //IfTrueResetTimer
            damageCountDownTimer = selectedEnemyTimer;
            //CheckThisIsNotTheFirstTimeTheScriptHasBeenRunThrough
            if(!firstRun){
                //IfNotApplyDamageToTheTurret
                defenceObjectsHealth -= selectedEnemyDamage;
                //DeleteTheObjectInstanceWhenHealthIs0OrBelow
                checkHealth();
            }
            //SetFirstRunToFalseWhenScriptHasReachedTheEndOfItsFirstPass
            firstRun = false;
        }
        //IfTheTimerHasNotStoppedCountItDown
        else if(damageCountDownTimer > 0){
            damageCountDownTimer -= Time.deltaTime;
        }
    }

    //DeleteTheObjectInstanceWhenHealthIs0OrBelow
    void checkHealth(){
        if(defenceObjectsHealth <= 0){
            Destroy(this.gameObject);
        }
    }

    //CheckForCollisionWithWreackingBallAndInstantlyDestroyTheTurret
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.name == "obj_wreackingBall(Clone)"){
            Destroy(this.gameObject);
        }
    }
}
