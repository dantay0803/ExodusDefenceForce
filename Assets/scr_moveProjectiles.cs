using UnityEngine;
using System.Collections;

public class scr_moveProjectiles : MonoBehaviour {
    //SetTheSpeedOfEachEnemyObject
    float movementSpeed;

    void Awake(){
        //IfMoveProjectileSpawnsOnLeftGrid
        if(this.transform.position.x < 7){
            //SetMovementSpeedToNegativeToMoveLeft
            movementSpeed = -5;
            //FlipTheImageIfItSpawnsOnTheLeftGrid
            flipImage();
        }
        //IfMoveProjectileSpawnsOnRight
        else if (this.transform.position.x > 7){
            //SetMovementSpeedToPositiveToMoveRight
            movementSpeed = 5;
        }
    }

    // Update is called once per frame
    void Update(){
        //MoveProjectile
        moveProjectile();
    }

    //MoveProjectile
    void moveProjectile(){
        //GetTheObjectsCurrentPosition
        Vector2 projectilePos = this.transform.position;
        //MoveProjectile
        projectilePos.x += movementSpeed * Time.deltaTime;
        //MoveObjectToNewPosition
        this.transform.position = projectilePos;
        //CheckIfProjectileIsOutOfTheScreenAndDestroyTheObjects
        outOfBounds();
    }

    //FlipTheImageIfItSpawnsOnTheLeftGrid
    void flipImage(){
        //GetTheCurretRotationvaluesOfTheObject
        Vector3 imageScale = transform.localScale;
        //FlipTheImageOnItsYAxis
        imageScale.x *= -1;
        //UpdateImageRotation
        transform.localScale = imageScale;
    }

    //CheckIfProjectileIsOutOfTheScreenAndDestroyTheObjects
    void outOfBounds(){
        if(this.transform.position.x < -8 || this.transform.position.x > 22){
            Destroy(this.gameObject);
        }
    }
}
