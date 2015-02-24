using UnityEngine;
using System.Collections;

public class scr_attackEnemy : MonoBehaviour {

    //set fire rate to have a 15 second pause between shots
    public float fireRate;
    public float timer; 
    //Define attack object 
    public GameObject projectile;


    //public float range = 576;
    public float range = 192;

    // Update is called once per frame
    void Update(){
        checkEnemyInRange();
    }


    void checkEnemyInRange(){
        //Store enemy object that exists
        GameObject targetObject = null;
        //Find what enemy object exists in the scene
        if(GameObject.Find("obj_fireSpitter") != null){
            targetObject = GameObject.Find("obj_fireSpitter");
        }
        if(GameObject.Find("obj_gatherer") != null){
            targetObject = GameObject.Find("obj_gatherer");
        }
        if(GameObject.Find("obj_hunter") != null){
            targetObject = GameObject.Find("obj_hunter");
        }
        if(GameObject.Find("obj_reinforcedWorker") != null){
            targetObject = GameObject.Find("obj_reinforcedWorker");
        }
        if (GameObject.Find("obj_rocky") != null){
            targetObject = GameObject.Find("obj_rocky");
        }
        if (GameObject.Find("obj_wheelWorker") != null){
            targetObject = GameObject.Find("obj_wheelWorker");
        }
        if (GameObject.Find("obj_worker") != null){
            targetObject = GameObject.Find("obj_worker");
        }
        if (GameObject.Find("obj_wreackingBall") != null){
            targetObject = GameObject.Find("obj_wreackingBall");
        }
        if (GameObject.Find("obj_zapper") != null){
            targetObject = GameObject.Find("obj_zapper");
        }
        //Ensure the target object is not null
        if (targetObject != null){
            //Check the enemy object is in range and on the same Y position
            if((targetObject.transform.position.y == this.transform.position.y) && (targetObject.transform.position.x >= this.transform.position.x - range)){
                //If all of the check are true fire at the enemy
                fireProjectile();
            }
        }
    }



    //Fire projectile
    void fireProjectile(){
        //Attack countdown
        timer -= Time.deltaTime;
        //Check timer
        if(timer <= 0){
            //Reset timer to fire again
            timer = fireRate;
            //Create new instance of projectile
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
	






}
