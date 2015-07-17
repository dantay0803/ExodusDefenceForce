using UnityEngine;
using System.Collections;

public class scr_turretShoot : MonoBehaviour {
    //DefineTheTurretsProjectile
    public GameObject projectile;
    //SetTheFireRateOfTheTurretAndDefineATimer
    public float fireRate, fireRange, countDownTimer;
    //SetTheDelayForTheSecondaryLauncher
    float secondaryCountDownTimer = 1, secondaryProjectileDelay = 1;
    //UseABoolToCheckIfASecondaryProjectileShouldBeCreated
    bool createSecondaryLauncher = false;

    // Use this for initialization
    void Awake () {
        countDownTimer = fireRate;
    }
	
	// Update is called once per frame
	void Update () {
        //CheckIfAnyEnemyObjectsAreInfrontOfTheTurret
        checkForCollision();
        //LaunchASecondProjectileForSpecificTurrets
        if (createSecondaryLauncher){
            //LaunchASecondProjectileForSpecificTurrets
            launchSecondProjectile();
        }
    }

    //CheckIfAnyEnemyObjectsAreInfrontOfTheTurret
    void checkForCollision(){
        //GetTheObjectsCurrentPosition
        Vector2 objectPos = this.transform.position, rightRadius = this.transform.position, leftRadius = this.transform.position;
        //SetTheDistanceTheRaycastShouldCheckToTheRightOfTheTurret
        rightRadius.x += fireRange;
        //SetTheDistanceTheRaycastShouldCheckToTheLeftOfTheTurret
        leftRadius.x -= fireRange;
        //CreateRayCastsToChechForCollisions
        RaycastHit2D leftHit = Physics2D.Linecast(objectPos, leftRadius, 1 << LayerMask.NameToLayer("enemyObjects"));
        RaycastHit2D rightHit = Physics2D.Linecast(objectPos, rightRadius, 1 << LayerMask.NameToLayer("enemyObjects"));
        //DefenceObjectOnLeftGrid
        if (this.transform.position.x < 7){
            //CheckForEnemyObjectInFrontOfDefence
            if (leftHit){
                //IfTheTurretDetectsAnEnemyObjectStartATimerToLaunchAProjectile
                launchProjectile();
            }
            //IfNoCollisionResetDamageTimer
            else{
                countDownTimer = fireRate;
            }
        }
        //DefenceObjectOnRightGrid
        else if (this.transform.position.x > 7){
            //CheckForEnemyObjectInFrontOfDefence
            if (rightHit){
                //IfTheTurretDetectsAnEnemyObjectStartATimerToLaunchAProjectile
                launchProjectile();
            }
            //IfNoCollisionResetDamageTimer
            else{
                countDownTimer = fireRate;
            }
        }
    }

    //IfTheTurretDetectsAnEnemyObjectStartATimerToLaunchAProjectile
    void launchProjectile(){
        if (countDownTimer <= 0){
            //ResetTimer
            countDownTimer = fireRate;
            //SpawnTheTeslaBoltInFrontOfTheTeslaCoil
            if (this.gameObject.name == "obj_tesla(Clone)") {
                if (this.gameObject.transform.position.x < 7){
                    Instantiate(projectile, new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (this.gameObject.transform.position.x > 7){
                    Instantiate(projectile, new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
            }
            //SpawnAllOtherProjectiles
            else{
                if (this.gameObject.transform.position.x < 7){
                    Instantiate(projectile, new Vector3(this.transform.position.x - 0.7f, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
                else if (this.gameObject.transform.position.x > 7){
                    Instantiate(projectile, new Vector3(this.transform.position.x + 0.7f, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                }
            }
            //LaunchASecondProjectileIfTheObjectIsTheAOBOrNeonTurrets
            if(this.gameObject.name == "obj_aob(Clone)" || this.gameObject.name == "obj_neon(Clone)"){
                createSecondaryLauncher = true;
            }
        }
        else if (countDownTimer > 0){
            countDownTimer -= Time.deltaTime;
        }
    }

    //LaunchASecondProjectileForSpecificTurrets
    void launchSecondProjectile(){
        if(secondaryCountDownTimer <= 0){
            //SpawnProjectile
            Instantiate(projectile, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            createSecondaryLauncher = false;
            secondaryCountDownTimer = secondaryProjectileDelay;
        }
        else if(secondaryCountDownTimer > 0){
            secondaryCountDownTimer -= Time.deltaTime;
        }
    }
}
