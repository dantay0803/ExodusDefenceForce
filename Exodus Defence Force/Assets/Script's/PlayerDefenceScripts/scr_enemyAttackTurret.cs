using UnityEngine;
using System.Collections;

public class scr_enemyAttackTurret : MonoBehaviour {

    //Store enemy object that exists
    GameObject targetObject = null;
    //Set the amount of damage each enemy will inflict
    float damageValue;

    float timer = 3;

	// Update is called once per frame
	void Update () {

        checkEnemyInFrontOfTurret();
	
	}

    //Check if there is an enemy infront of a turret
    void checkEnemyInFrontOfTurret(){
        //Find what enemy object exists in the scene and is on the same Y position
        if (GameObject.Find("obj_fireSpitter") != null && GameObject.Find("obj_fireSpitter").transform.position.y == this.transform.position.y){
            targetObject = GameObject.Find("obj_fireSpitter");
            damageValue = 10;
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

        //Check if target object is not found
        if (targetObject != null)
        {
            //If target object is found check if the target objetc is more than one grid space infront of the turret on the left grid
            if (this.transform.position.x < 13 && targetObject.transform.position.x >= this.transform.position.x - 1){
                damageTurret();
                Debug.Log("Damage turret ran");
            }
            //If target object is found check if the target objetc is more than one grid space infront of the turret on the right grid
            else if (this.transform.position.x < 13 && targetObject.transform.position.x <= this.transform.position.x + 1){
                damageTurret();
            }

        }
    }

    //Enemy damage Turret
    void damageTurret(){
        //Count down to attack turret
        timer -= Time.deltaTime;
        //Attack turret once timer is finished
        if(timer <= 0){
            this.GetComponent<scr_checkObjectsHealth>().objectHealth -= damageValue;
            //Reset timer
            timer = 10;
        }
    }





}
