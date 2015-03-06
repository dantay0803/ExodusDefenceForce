using UnityEngine;
using System.Collections;

public class scr_attackEnemy : MonoBehaviour {

    //set fire rate to have a 15 second pause between shots
    public float fireRate;
    public float timer; 
    //Define attack object 
    public GameObject projectile;

    bool secondNeonProjectileFired = false;

    //public float range = 576;
    public float range = 192;

    // Update is called once per frame
    void Update(){
        checkEnemyInRange();
    }


    void checkEnemyInRange(){
        //Store enemy object that exists
        GameObject targetObject = null;
        //Find what enemy object exists in the scene and is on the same Y position
        if(GameObject.Find("obj_fireSpitter") != null && GameObject.Find("obj_fireSpitter").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_fireSpitter");
        }
        if (GameObject.Find("obj_gatherer") != null && GameObject.Find("obj_gatherer").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_gatherer");
        }
        if (GameObject.Find("obj_hunter") != null && GameObject.Find("obj_hunter").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_hunter");
        }
        if (GameObject.Find("obj_reinforcedWorker") != null && GameObject.Find("obj_reinforcedWorker").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_reinforcedWorker");
        }
        if (GameObject.Find("obj_rocky") != null && GameObject.Find("obj_rocky").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_rocky");
        }
        if (GameObject.Find("obj_wheelWorker") != null && GameObject.Find("obj_wheelWorker").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_wheelWorker");
        }
        if (GameObject.Find("obj_worker") != null && GameObject.Find("obj_worker").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_worker");
        }
        if (GameObject.Find("obj_wreackingBall") != null && GameObject.Find("obj_wreackingBall").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_wreackingBall");
        }
        if (GameObject.Find("obj_zapper") != null && GameObject.Find("obj_zapper").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_zapper");
        }
        //Ensure the target object is not null
        if (targetObject != null){
            //Check enemy object is still on the same Y position
            if(targetObject.transform.position.y == this.transform.position.y){
                //Check enemy is in range on the left grid
                if((targetObject.transform.position.x < 13) && (targetObject.transform.position.x >= this.transform.position.x - range)){
                    //If all of the check are true fire at the enemy
                    fireProjectile();
                }
                //Check enemy is in range on teh right grid
                else if((targetObject.transform.position.x > 13) && (targetObject.transform.position.x <= this.transform.position.x + range)){
                    //If all of the check are true fire at the enemy
                    fireProjectile();
                }
            }
        }
    }



    //Fire projectile
    void fireProjectile(){
        //Attack countdown
        timer -= Time.deltaTime;
        //For N.E.O.N turret fire a first projectile half a second early
        if (this.gameObject.name == "obj_neon(Clone)" && timer <= 0.5 && secondNeonProjectileFired == false){
            //Create new instance of projectile
            Instantiate(projectile, transform.position, transform.rotation);
            secondNeonProjectileFired = true;
        }
        //Check timer
        if(timer <= 0){
            //Reset timer to fire again
            timer = fireRate;
            //Create new instance of projectile
            Instantiate(projectile, transform.position, transform.rotation);

            secondNeonProjectileFired = false;
        }
    }
}
