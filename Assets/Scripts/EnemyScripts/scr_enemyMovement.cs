using UnityEngine;
using System.Collections;

public class scr_enemyMovement : MonoBehaviour {

    public static scr_enemyMovement instance;
    //DefineTheObjectAnimatorComponent
    Animator anim;

    //SetTheSpeedOfEachEnemyObject
    public float movementSpeed;
	
    //Run at start
    void Awake(){
        instance = this;
    }

	// Update is called once per frame
	void Update (){
        //MoveEnemy
        moveEnemy();
	}

    //MoveEnemyObject
    void moveEnemy(){
        //GetTheObjectsCurrentPosition
        Vector2 enemyPos = this.transform.position;
        //SetTheDistanceTheRaycastShouldCheckWhenMovingRight
        Vector2 rightRadius = this.transform.position;
        rightRadius.x += 0.5f;
        //SetTheDistanceTheRaycastShouldCheckWhenMovingLeft
        Vector2 leftRadius = this.transform.position;
        leftRadius.x -= 0.5f;
        //EnemyIsOnLeftGridAndNoCollisionIsDetecedWithObjectsOnTheDefenceLayerOrIfTheObjectIsTheWreackingBallMoveNoMatterWhat
        if (this.transform.position.x < 7 && (!Physics2D.Linecast(enemyPos, rightRadius, 1 << LayerMask.NameToLayer("defenceObjects")) || this.gameObject.name == "obj_wreackingBall(Clone)")){
            enemyPos.x += movementSpeed * Time.deltaTime;
        }
        //EnemyIsOnRightGridAndNoCollisionIsDetecedWithObjectsOnTheDefenceLayerOrIfTheObjectIsTheWreackingBallMoveNoMatterWhat
        else if (this.transform.position.x > 7 && (!Physics2D.Linecast(enemyPos, leftRadius, 1 << LayerMask.NameToLayer("defenceObjects")) || this.gameObject.name == "obj_wreackingBall(Clone)")){
            enemyPos.x -= movementSpeed * Time.deltaTime;
        }
        //RunAttackAnimationIfDefenceInfrontOfEnemy
        else {
            //GetTheAnimatorComponent
            anim = this.GetComponent<Animator>();
            //SetTheAnimationToAttackAnimation
            anim.SetInteger("enemyState", 1);

        }
        //MoveObjectToNewPosition
        this.transform.position = enemyPos;
    }
}
