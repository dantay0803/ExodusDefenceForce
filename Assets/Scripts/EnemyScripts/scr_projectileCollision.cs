using UnityEngine;
using System.Collections;

public class scr_projectileCollision : MonoBehaviour {
    //SetObjectsHealth
    public int objectsHealth;
    //HoldTheNameOfTheEnemyObjectInfrontOfTheTurret
    string projectileObjectName;
    //DefineTurretDamageValue
    int obj_aobProjectileDamage = 10, obj_bobProjectileDamage = 10, obj_buzzProjectileDamage = 20, obj_fatManProjectileDamage = 250, obj_mk48ProjectileDamage = 80;
    int obj_neonProjectileDamage = 25, obj_rayProjectileDamage = 250, obj_scatterBoxProjectileDamage = 40, obj_teslaProjectileDamage = 10, obj_toastyProjectileDamage = 5;
    //DefineMineDamageValue
    int obj_bigBoyDamage = 180, obj_mineDamage = 175, obj_fireMineDamage = 100;
    //BlastRadiusDamage
    int obj_fatManBlastRadiusDamage = 125, obj_bigBoyBlastRadiusDamage = 80, obj_mk48BlastRadiusDamage = 10;
    //SetTheTimerTheFireDamageShouldLastFor
    float fireDamageTimer = 3;
    //TrackIfFireDamageShouldBeAppliedToObject
    bool applyFireDamage = false;
    //StopTheObjectFromTakingExtraDamage
    bool fireDamageFirstBurn = false, fireDamageSecondBurn = false;
    //SaveTheenemyObjectsMovementSpeedAndSetTheTimerOfTheLNLEffect
    float lnlSavedMovementSpeed = 0, lnlEffectTimer = 3;
    //KeepTrackOfTheEffectRunningAndIfTheObjectsMovementSpeedHasBeenSaved
    bool lnlMovementSpeedSaved = false, lnlEffectRunning = false;
    //SaveTheenemyObjectsMovementSpeedAndSetTheTimerOfThekolokoloEffect
    float kolokoloSavedMovementSpeed = 0, kolokoloEffectTimer = 3;
    //KeepTrackOfTheEffectRunningAndIfTheObjectsMovementSpeedHasBeenSaved
    bool kolokoloMovementSpeedSaved = false, kolokoloEffectRunning = false;
    //DefineTheBlastRadiusObjectsToBeSpawned
    public GameObject obj_fatManBlastRadius, obj_bigBoyBlastRadius, obj_mk48BlastRadius;


    //Run every frame
    void Update(){
        //ApplyFireDamageToEnemyThatCollidesWithToastyFlamesOrFireMine
        if (applyFireDamage){
            fireDamage();
        }
        //ApplyLnLEffect
        if(lnlEffectRunning){
            lnlEffectOnEnemyObject();
        }
        //ApplykolokoloEffect
        if (kolokoloEffectRunning){
            kolokoloEffectOnEnemyObject();
        }
    }

    //ApplyDamageToTheTurretsWhenACollisionIsDetected
    void applyDamage(){
        //CheckTheNameOfTheProjectileCollidedWithAndApplyDamage
        switch (projectileObjectName){
            case "obj_aobProjectile(Clone)":
                objectsHealth -= obj_aobProjectileDamage;
                break;
            case "obj_bobProjectile(Clone)":
                objectsHealth -= obj_bobProjectileDamage;
                break;
            case "obj_buzzProjectile(Clone)":
                objectsHealth -= obj_buzzProjectileDamage;
                break;
            case "obj_fatManProjectile(Clone)":
                objectsHealth -= obj_fatManProjectileDamage;
                //SpawnInstancesOfTheFatManBlastRadius
                spawnFatManBlastRadius();
                break;
            case "obj_mk48Projectile(Clone)":
                objectsHealth -= obj_mk48ProjectileDamage;
                //SpawnBlastRadius
                Instantiate(obj_mk48BlastRadius, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                break;
            case "obj_neonProjectile(Clone)":
                objectsHealth -= obj_neonProjectileDamage;
                break;
            case "obj_rayProjectile(Clone)":
                objectsHealth -= obj_rayProjectileDamage;
                break;
            case "obj_scatterBoxProjectile(Clone)":
                objectsHealth -= obj_scatterBoxProjectileDamage;
                break;
            case "obj_teslaProjectile(Clone)":
                objectsHealth -= obj_teslaProjectileDamage;
                break;
            case "obj_toastyProjectile(Clone)":
                objectsHealth -= obj_toastyProjectileDamage;
                //RunFireDamageVariable
                applyFireDamage = true;
                break;
            case "obj_lnlProjectile(Clone)":
                //RunlnlEffect
                lnlEffectRunning = true;
                break;
            //MineCollision
            case "obj_bigBoy(Clone)":
                objectsHealth -= obj_bigBoyDamage;
                //SpawnInstancesOfTheBigBoyBlastRadius
                spawnBigBoyBlastRadius();
                break;
            case "obj_mine(Clone)":
                objectsHealth -= obj_mineDamage;
                break;
            case "obj_fireMine(Clone)":
                objectsHealth -= obj_fireMineDamage;
                //RunFireDamageVariable
                applyFireDamage = true;
                break;
            case "obj_kolokolo(Clone)":
                //RunKolokoloEffect
                kolokoloEffectRunning = true; 
                break;
            //BlastRadiusCollision
            case "obj_bigBoyBlastRadius(Clone)":
                objectsHealth -= obj_bigBoyBlastRadiusDamage;
                break;
            case "obj_fatManBlastRadius(Clone)":
                objectsHealth -= obj_fatManBlastRadiusDamage;
                break;
            case "obj_mk48BlastRadius(Clone)":
                objectsHealth -= obj_mk48BlastRadiusDamage;
                break;
        }
        //DeleteTheObjectInstanceWhenHealthIs0OrBelow
        checkHealth();
    }

    //CheckForCollisionWithWreackingBallAndInstantlyDestroyTheTurret
    void OnTriggerEnter2D(Collider2D coll){
        projectileObjectName = coll.name;
        applyDamage();
        if(coll.gameObject.name != "bg_levelOne") {
            Destroy(coll.gameObject);
        }
    }

    //DeleteTheObjectInstanceWhenHealthIs0OrBelow
    void checkHealth(){
        if (objectsHealth <= 0){
            Destroy(this.gameObject);
        }
    }

    //ApplyFireDamageToEnemyThatCollidesWithToastyFlamesOrFireMine
    void fireDamage(){
        //RandomlyGenerateARandomFireDamageValue
        int fireDamage = Random.Range(1, 4);
        //Apply
        if(fireDamageTimer > 0){
            fireDamageTimer -= Time.deltaTime;
            //ApplyDamageToObject
            if((int)fireDamageTimer == 2 && !fireDamageFirstBurn){
                //TakeHealthOffDueToFireDamage
                objectsHealth -= fireDamage;
                //DeleteTheObjectInstanceWhenHealthIs0OrBelow
                checkHealth();
                //StopObjectFromTakingDamageMoreThanOnce
                fireDamageFirstBurn = true;
            }
            if((int)fireDamageTimer == 1 && !fireDamageSecondBurn){
                //TakeHealthOffDueToFireDamage
                objectsHealth -= fireDamage;
                //DeleteTheObjectInstanceWhenHealthIs0OrBelow
                checkHealth();
                //StopObjectFromTakingDamageMoreThanOnce
                fireDamageSecondBurn = true;
            }
            if((int)fireDamageTimer == 0){
                //TakeHealthOffDueToFireDamage
                objectsHealth -= fireDamage;
                //DeleteTheObjectInstanceWhenHealthIs0OrBelow
                checkHealth();
                //StopApplyingFireDamage
                applyFireDamage = false;
                //ResetTimer
                fireDamageTimer = 3;
                //ResetBoolsToStopExtraFireDamage
                fireDamageFirstBurn = false;
                fireDamageSecondBurn = false;
            }
        }
    }

    //StopEnemyFromMovingIfTheyCollideWithTheLNLBullet
    void lnlEffectOnEnemyObject(){
        //IfTheObjectsMovementSpeedHasNotBeenSavedSaveIt
        if (!lnlMovementSpeedSaved){
            lnlSavedMovementSpeed = scr_enemyMovement.instance.movementSpeed;
            //UseBoolToStopTheSavedSpeedBeingOverwrote
            lnlMovementSpeedSaved = true;
        }
        if (lnlEffectTimer > 0){
            //FreezeEnemyObject
            scr_enemyMovement.instance.movementSpeed = 0;
            //CountDownEffect
            lnlEffectTimer -= Time.deltaTime;
        }
        else if(lnlEffectTimer <= 0){
            //ResetObjectsMovementSpeed
            scr_enemyMovement.instance.movementSpeed = lnlSavedMovementSpeed;
            //SetEffectToNotRunning
            lnlEffectRunning = false;
            //ResetEffectTimer
            lnlEffectTimer = 3;
        }
    }

    //StopEnemyFromMovingIfTheyCollideWithTheKolokoloMine
    void kolokoloEffectOnEnemyObject(){
        //IfTheObjectsMovementSpeedHasNotBeenSavedSaveIt
        if (!kolokoloMovementSpeedSaved){
            kolokoloSavedMovementSpeed = scr_enemyMovement.instance.movementSpeed;
            //UseBoolToStopTheSavedSpeedBeingOverwrote
            kolokoloMovementSpeedSaved = true;
            //SlowDownEnemyObject
            scr_enemyMovement.instance.movementSpeed = scr_enemyMovement.instance.movementSpeed / 2;
        }
        if (kolokoloEffectTimer > 0){
            //CountDownEffect
            kolokoloEffectTimer -= Time.deltaTime;
        }
        else if (kolokoloEffectTimer <= 0){
            //ResetObjectsMovementSpeed
            scr_enemyMovement.instance.movementSpeed = kolokoloSavedMovementSpeed;
            //SetEffectToNotRunning
            kolokoloEffectRunning = false;
            //ResetEffectTimer
            kolokoloEffectTimer = 3;
        }
    }

    //SpawnInstancesOfTheFatManBlastRadius
    void spawnFatManBlastRadius(){
        //SetTheFirstSpawnPointForTheBlastRadius
        float xPos = 6.5f;
        //CreateAnInstanceOfTheFatManBlastRadiusOnEverySpaceAlongYAxisWhereTheCollisionOccured
        for(int i=0; i<9; i++){
            Instantiate(obj_fatManBlastRadius, new Vector3(xPos, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            xPos++;
        }
    }

    //SpawnInstancesOfTheBigBoyBlastRadius
    void spawnBigBoyBlastRadius(){
        //SpawnOnInstanceOfTheBlastRadiuesOnTheCollisionPosition
        Instantiate(obj_bigBoyBlastRadius, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        //CheckIfThereIsASpacesAtEitherSideOfTheCollisionAndSpawnAnInstanceOfTheBlastRadiusIfThereIs
        if (this.transform.position.y != -0.5){
            Instantiate(obj_bigBoyBlastRadius, new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z), Quaternion.identity);
        }
        if (this.transform.position.y != -4.5){
            Instantiate(obj_bigBoyBlastRadius, new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z), Quaternion.identity);
        }
        if(this.transform.position.x != -6.5){
            Instantiate(obj_bigBoyBlastRadius, new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        }
        if (this.transform.position.x != 1.5)
        {
            Instantiate(obj_bigBoyBlastRadius, new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        }





    }
}
